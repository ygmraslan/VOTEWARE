using System;
using Business.Abstract;
using Business.Contants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete
{
    public class EventManager : IEventService
    {
        private IEventDal _eventDal;
        public EventManager(IEventDal eventDal)
        {
            _eventDal = eventDal;
        }

        public IResult Add(Event @event)
        {
            _eventDal.Add(@event);
            return new SuccessResult(Messages.EventAdded);
        }

        public IResult Delete(Event @event)
        {
            _eventDal.Delete(@event);
            return new SuccessResult(Messages.EventDeleted);
        }

        public IDataResult<Event> GetById(int eventId)
        {
            return new SuccessDataResult<Event>(_eventDal.Get(e=> e.EventID == eventId));
        }

        public IDataResult<List<Event>> GetList()
        {
            return new SuccessDataResult<List<Event>>(_eventDal.GetList().ToList());
        }

        public IResult Update(Event @event)
        {
            _eventDal.Update(@event);
            return new SuccessResult(Messages.EventUpdated);
        }
    }
}

