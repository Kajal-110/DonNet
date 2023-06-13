using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theam_Login_Register.Helpers.Helpers;
using Theam_Login_Register.Models.Context;
using Theam_Login_Register.Models.Model;
using Theam_Login_Register.Repositories.Repositories;

namespace Theam_Login_Register.Repositories.Services
{
    public class UserService :IUser
    {
        KajalPatel_SIT0330Entities _context = new KajalPatel_SIT0330Entities();

        public string Register(UserModel userModel)
        {
            try
            {
                User user = new User();
                user = UserHelper.ConvertToUserModel(userModel);
                if (user != null)
                {
                    _context.User.Add(user);
                    _context.SaveChanges();
                    return "Success";
                }
                else
                {
                    return "Fail";
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }


        }
    }
}
