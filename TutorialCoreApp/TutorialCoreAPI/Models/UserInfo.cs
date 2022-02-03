﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TutorialCoreAPI.Models
{
    //OAuth
    //JWT - Json web Token
    public class UserInfo
    {
        [Key]
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public Decimal Mobile { get; set; }
        public string Pwd { get; set; }
    }
}
