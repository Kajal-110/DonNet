using SchoolManagement_SIT0330.Models.Context;
using SchoolManagement_SIT0330.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_SIT0330.Repository.Ropositories
{
    public interface ICity
    {
        List<CityModel> GetAllCityList();

        string CreateCity(CityModel cityModel);

        List<Country> GetALLCountry();

        List<State> GetAllState(int CountryId);

        List<City> GetAllCity(int StateId);
    }
}
