﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Food_Order.Models
{
    public class UserLogin_Validation
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
    [MetadataType(typeof(UserLogin_Validation))]
    public partial class UserLogin
    {

    }
}