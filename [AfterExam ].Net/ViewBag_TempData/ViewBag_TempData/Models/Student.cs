﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewBag_TempData.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }
        public int PostalCode { get; set; }
    }
}