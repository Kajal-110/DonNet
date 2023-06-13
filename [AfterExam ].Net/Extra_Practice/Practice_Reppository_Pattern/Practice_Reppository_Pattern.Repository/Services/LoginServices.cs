using Practice_Reppository_Pattern.Models.Context;
using Practice_Reppository_Pattern.Models.Models;
using Practice_Reppository_Pattern.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Reppository_Pattern.Repository.Services
{
    public class LoginServices : LoginInterface
    {
        Kajalpatel5_13_2023Entities _context =new  Kajalpatel5_13_2023Entities();
        public String LoginUser(LoginInformationModel loginInformation)
        {
            try
            {
                LoginInformation Login = _context.LoginInformation.Where(x => x.UserName.Equals(loginInformation.UserName)).FirstOrDefault();
                if(Login != null)
                {
                    //var aa = _context.LoginInformation.Where(x => x.UserName.Equals()).FirstOrDefault();
                    if (Login.Password.Equals(loginInformation.Password))                   
                    {
                        return Convert.ToString(Login.Id);
                    }
                    else
                    {
                        return "Invalid Password";
                    }
                }
                 return "Invalid Email";
            }
            catch (Exception e)
            {

                throw e;
            }
            
        }
    }
}
