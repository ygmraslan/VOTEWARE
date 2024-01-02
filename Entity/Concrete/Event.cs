using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Event:IEntity
	{
        public int EventID { get; set; }
        public string EventName { get; set; }
        public string Description { get; set; }
    }
}

