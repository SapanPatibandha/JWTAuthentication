﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AnyAPI.Models
{
    public class LoginModel
    {
        [Required]
        public string UserName { get; set; }
        //[Required]
        //public string Password { get; set; }
        [Required]
        public Guid ID { get; set; }

    }
}
