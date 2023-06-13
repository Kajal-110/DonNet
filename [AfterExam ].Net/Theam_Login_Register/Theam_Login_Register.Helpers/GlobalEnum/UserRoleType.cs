using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theam_Login_Register.Helpers.GlobalEnum
{
     public enum UserRoleType
     {
        [Display(Name="SuperAdmin")]
        SuperAdmin=1,
        [Display(Name = " Admin")]
        Admin =2,
        [Display(Name = "User")]
         User =3
     }
}
