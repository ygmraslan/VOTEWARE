using System;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IDateService
	{
        IDataResult<Date> GetById(int dateId);

        IDataResult<List<Date>> GetList();

        IResult Add(Date date);
        IResult Delete(Date date);
        IResult Update(Date date);
    }
}

