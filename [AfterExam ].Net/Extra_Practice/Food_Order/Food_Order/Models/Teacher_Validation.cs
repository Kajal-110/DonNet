using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Food_Order.Models
{
    public class Teacher_Validation
    {
        public int TeaacherId { get; set; }
        [Required]
        public string TeacherName { get; set; }
        [Required]

        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public Nullable<int> Gender { get; set; }
        [Required]
        public string City { get; set; }
    }
    
}