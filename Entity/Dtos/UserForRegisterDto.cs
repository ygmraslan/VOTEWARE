﻿using System;
using Core.Entities;

namespace Entities.Dtos
{
	public class UserForRegisterDto:IDto
	{
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

