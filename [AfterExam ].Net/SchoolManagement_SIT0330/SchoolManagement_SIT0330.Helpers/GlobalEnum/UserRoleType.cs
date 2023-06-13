using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_SIT0330.Helpers.Helpers
{
    public enum UserRoleType
    {
        [Display(Name= " Admin")]
        SuperAdmin=1,
        [Display(Name = " Manager")]
        Admin =2,
        [Display(Name = "Customer")]
        User =3
    }
}
