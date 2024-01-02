using System;

namespace Core.Entities.Concrete
{
	public class User:IEntity 
	{
		public int UserID { get; set; }
		public string UserName { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
	}
}

