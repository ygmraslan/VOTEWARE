using System;
using System.Linq.Expressions;
using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEventDal : EfEntityRepositoryBase<Event,VoteWareContext>,IEventDal
    {
        
    }
}

