using SchoolManagement_SIT0330.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_SIT0330.Repositories.Repositories
{
     public interface IUser
    {
        string Register(UserModel userModel);
    }
}
