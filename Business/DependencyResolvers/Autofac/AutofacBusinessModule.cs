using System;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
	public class AutofacBusinessModule:Module
	{
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<EventManager>().As<IEventService>();
            builder.RegisterType<EfEventDal>().As<IEventDal>();

            builder.RegisterType<DateManager>().As<IDateService>();
            builder.RegisterType<EfDateDal>().As<IDateDal>();

            builder.RegisterType<VoteManager>().As<IVoteService>();
            builder.RegisterType<EfVoteDal>().As<IVoteDal>();
        }
    }
}

