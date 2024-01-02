using System;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IUserService
	{
        IDataResult<User> GetById(int userId);

        IDataResult<User>GetByMail(string email);

		IDataResult<List<User>>GetList();

		IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
    }
}

