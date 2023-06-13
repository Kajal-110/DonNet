using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theam_Login_Register.Models.Context;
using Theam_Login_Register.Models.Model;

namespace Theam_Login_Register.Helpers.Helpers
{
    public class UserHelper
    {

        public static User ConvertToUserModel(UserModel userModel)
        {
            User user = new User();
            user.UserId = userModel.UserID;
            user.FirstName = userModel.FirstName;
            user.LastName = userModel.LastName;
            user.Email = userModel.Email;
            user.Password = userModel.Password;
            user.ConfirmPasword = userModel.Confirm_Password;
            user.Role = userModel.Role;
            return user;
        }
    }
}
