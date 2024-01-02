using System;
using Core.Entities;

namespace Entities.Concrete
{
	public class Date:IEntity
	{
        public int DateID { get; set; }
        public DateTime Date1 { get; set; }
        public DateTime Date2 { get; set; }
        public DateTime Date3 { get; set; }
    }
}

