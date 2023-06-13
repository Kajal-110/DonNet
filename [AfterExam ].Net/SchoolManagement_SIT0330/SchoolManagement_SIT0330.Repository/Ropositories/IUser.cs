using SchoolManagement_SIT0330.Models.Context;
using SchoolManagement_SIT0330.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_SIT0330.Repository.Ropositories
{
    public interface IUser
    {
        string Register(UserModel userModel);

        List <UserModel> GetAllUser();

        UserModel GetUserByUserId( int id);

        UserModel EditUserModel(int id);

        int  PostUserData(UserModel usermodel);

        User DeleteUser(int id);

        void Save();

        User LoginUser(UserModel userModel);
        
    }
}
