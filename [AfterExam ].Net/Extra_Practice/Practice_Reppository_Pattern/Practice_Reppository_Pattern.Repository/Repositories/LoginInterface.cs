using Practice_Reppository_Pattern.Models.Context;
using Practice_Reppository_Pattern.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Reppository_Pattern.Repository.Repositories
{
    public interface LoginInterface
    {
        String LoginUser(LoginInformationModel userModel);
    }
}
