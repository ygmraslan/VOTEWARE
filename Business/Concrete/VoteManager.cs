using System;
using Business.Abstract;
using Business.Contants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete
{
    public class VoteManager : IVoteService
    {
        private IVoteDal _voteDal;
        public VoteManager(IVoteDal voteDal)
        {
            _voteDal = voteDal;
        }

        public IResult Add(Vote vote)
        {
            _voteDal.Add(vote);
            return new SuccessResult(Messages.VoteAdded);
        }

        public IResult Delete(Vote vote)
        {
            _voteDal.Delete(vote);
            return new SuccessResult(Messages.VoteDeleted);
        }

        public IDataResult<Vote> GetById(int voteId)
        {
            return new SuccessDataResult<Vote>(_voteDal.Get(v=> v.VoteID == voteId));
        }

        public IDataResult<List<Vote>> GetList()
        {
            return new SuccessDataResult<List<Vote>>(_voteDal.GetList().ToList());
        }

        public IResult Update(Vote vote)
        {
            _voteDal.Update(vote);
            return new SuccessResult(Messages.VoteUpdated);
        }
    }
}

