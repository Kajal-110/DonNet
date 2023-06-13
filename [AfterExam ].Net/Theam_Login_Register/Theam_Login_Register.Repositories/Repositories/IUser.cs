using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theam_Login_Register.Models.Model;

namespace Theam_Login_Register.Repositories.Repositories
{
    public interface IUser
    {
        string Register(UserModel userModel);
    }
}
