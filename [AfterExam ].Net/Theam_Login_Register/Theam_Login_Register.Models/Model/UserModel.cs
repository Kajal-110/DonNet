using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theam_Login_Register.Models.Model
{
     public class UserModel
    {
        public int UserID { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }


        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Please re-enter your Password")]
        public string Confirm_Password { get; set; }

        [Required]
        public int Role { get; set; }
    }
}
