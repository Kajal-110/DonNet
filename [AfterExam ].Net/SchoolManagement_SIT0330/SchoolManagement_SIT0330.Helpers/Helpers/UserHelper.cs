using SchoolManagement_SIT0330.Models.Context;
using SchoolManagement_SIT0330.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_SIT0330.Helpers.Helpers
{
        
    public class UserHelper
    {
        public static User convertToUserModel(UserModel userModel)
        {
            User user = new User();
            user.UserId = userModel.UserId;
            user.FirstName = userModel.FirstName;
            user.LastName = userModel.LastName;
            user.Email = userModel.Email;
            user.Password = userModel.Password;
            user.ConfirmPasword = userModel.ConfirmPasword;
            user.Role = userModel.Role;

            return user;
        }

        public static List<UserModel> convertUserToUserModel(List<User> users)
        {
            try
            {

                List<UserModel> userModel = new List<UserModel>();
                foreach (var item in users)
                {
                    UserModel UserList = new UserModel();
                    UserList.UserId = item.UserId;
                    UserList.FirstName = item.FirstName;
                    UserList.LastName = item.LastName;
                    UserList.Email = item.Email;
                    UserList.Password = item.Password;
                    UserList.Role = Convert.ToInt32(item.Role);
                    userModel.Add(UserList);

                }
                return userModel;
            }
            catch(System.Exception e)
            {
                throw e;
            }

        }

        public static UserModel convertUserToUserModelForId( User user)
        {
            try
            {
                    UserModel UserList = new UserModel();
                    UserList.UserId = user.UserId;
                    UserList.FirstName = user.FirstName;
                    UserList.LastName = user.LastName;
                    UserList.Email = user.Email;
                    UserList.Password = user.Password;
                    UserList.Role = Convert.ToInt32(user.Role);
               
                return UserList;
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static UserModel EditUser( User user)
        {
            UserModel usermodel = new UserModel();

            usermodel.UserId = user.UserId;
            usermodel.FirstName = user.FirstName;
            usermodel.LastName = user.LastName;
            usermodel.Email = user.Email;
            usermodel.Password = user.Password;
            usermodel.Role =Convert.ToInt32(user.Role);
            return usermodel;
        }
    }
}
