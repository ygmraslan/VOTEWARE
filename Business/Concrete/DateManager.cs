using System;
using Business.Abstract;
using Business.Contants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.Extensions.Logging;

namespace Business.Concrete
{
    public class DateManager : IDateService

    {
        private IDateDal _dateDal;
        public DateManager(IDateDal dateDal)
        {
            _dateDal = dateDal;
        }
        public IResult Add(Date date)
        {
            _dateDal.Add(date);
            return new SuccessResult(Messages.DateAdded);
        }

        public IResult Delete(Date date)
        {
            _dateDal.Delete(date);
            return new SuccessResult(Messages.DateDeleted);
        }

        public IDataResult<Date> GetById(int dateId)
        {
            return new SuccessDataResult<Date>(_dateDal.Get(d => d.DateID == dateId));
        }

        public IDataResult<List<Date>> GetList()
        {
            return new SuccessDataResult<List<Date>>(_dateDal.GetList().ToList());
        }

        public IResult Update(Date date)
        {
            _dateDal.Update(date);
            return new SuccessResult(Messages.DateUpdated);
        }
    }
}

