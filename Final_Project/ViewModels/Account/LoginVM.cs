﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.ViewModels.Account
{
	public class LoginVM
	{
        [Required]
        public string EmailOrUsername { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

