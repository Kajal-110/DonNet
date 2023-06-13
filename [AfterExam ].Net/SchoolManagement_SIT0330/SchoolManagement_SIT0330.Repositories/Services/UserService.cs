using SchoolManagement_SIT0330.Helpers.Helpers;
using SchoolManagement_SIT0330.Models.Context;
using SchoolManagement_SIT0330.Models.Model;
using SchoolManagement_SIT0330.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_SIT0330.Repositories.Services
{
   
     public class UserService :IUser
     {
        KajalPatel_SIT0330Entities _context = new KajalPatel_SIT0330Entities();
        public string  Register(UserModel userModel)
        {
            
            User user = new User();

             user = UserHelper.convertToUserModel(userModel);
            _context.User.Add(user);
            
            return "success";

        }

      
    }
}


