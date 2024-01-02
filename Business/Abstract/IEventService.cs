using System;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IEventService
	{
        IDataResult<Event> GetById(int eventId);

        IDataResult<List<Event>> GetList();

        IResult Add(Event @event);
        IResult Delete(Event @event);
        IResult Update(Event @event);

    }
}
