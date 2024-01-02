using System;
using Core.Entities;

namespace Entities.Concrete
{
	public class Vote:IEntity
	{
        public int VoteID { get; set; }
        public int Choice1 { get; set; }
        public int Choice2 { get; set; }
        public int Choice3 { get; set; }
    }
}

