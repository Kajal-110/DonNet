using SchoolManagement_SIT0330.Helpers.Helpers;
using SchoolManagement_SIT0330.Models.Context;
using SchoolManagement_SIT0330.Models.Model;
using SchoolManagement_SIT0330.Repository.Ropositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_SIT0330.Repository.Services
{
    public class UserServices : IUser
    {
        KajalPatel_SIT0330Entities _context = new KajalPatel_SIT0330Entities();
        public string Register(UserModel userModel)
        {
            try
            {
                User user = new User();
                user = UserHelper.convertToUserModel(userModel);
                if(user != null)
                {
                    _context.Users.Add(user);
                    _context.SaveChanges();
                    return "Success";
                }
                else
                {
                    return "Fail";
                }
            }
            catch(System.Exception e)
            {
                throw e;
            }
            

        }

     

        public List<UserModel> GetAllUser()
        {
            try
            {

                List<User> users = new List<User>();
                List<UserModel> usermodel = new List<UserModel>();

                users = _context.Users.ToList();
                if (users != null && users.Count > 0)
                {
                    usermodel = UserHelper.convertUserToUserModel(users);

                }
                return usermodel;
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public UserModel GetUserByUserId(int id)
        {
            try
            {
        

                User users = _context.Users.Where(x => x.UserId == id).FirstOrDefault();

                if(users != null )
                {
                  UserModel userdetail = UserHelper.convertUserToUserModelForId(users);
                   return userdetail;
                }
                else
                {
                    return null;
                }

                
            }
            catch(System.Exception e)
            {
                throw e;
            }
        }

        public UserModel EditUserModel(int id)
        {
            User user;
            user = _context.Users.Find(id);
           
            UserModel usermodel = UserHelper.EditUser(user);
            return usermodel;
        }

        public int PostUserData(UserModel usermodel)
        {
            try
            { 

                    User aa = UserHelper.convertToUserModel(usermodel);

                _context.Entry(aa).State = System.Data.Entity.EntityState.Modified;

                _context.SaveChanges();
                    return 1;
                
            }
            catch(Exception e)
            {
                throw e;
            } 

               
        }

        public User DeleteUser(int id)
        {
            var deleteUser=_context.Users.Find(id);
            if(deleteUser != null)
            {
            var delete=  _context.Users.Remove(deleteUser);
            _context.SaveChanges();
            return delete;

            }
            else
            {
                return null;
            }
        }

        public void Save()
        {
            
            _context.SaveChanges();
        }

         public User LoginUser(UserModel userModel)
        {
            
           
            var aa = _context.Users.Where(x => x.Email == userModel.Email && x.Password == userModel.Password).FirstOrDefault();

            if(aa != null)
            {
                return aa;
            }
            else
            {
                
                return null;
            }
            
        }

    }


}
