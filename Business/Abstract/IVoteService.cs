using System;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IVoteService
	{
        IDataResult<Vote> GetById(int voteId);

        IDataResult<List<Vote>> GetList();

        IResult Add(Vote vote);
        IResult Delete(Vote vote);
        IResult Update(Vote vote);
    }
}

