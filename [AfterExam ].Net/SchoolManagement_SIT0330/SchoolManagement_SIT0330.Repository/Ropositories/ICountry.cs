using SchoolManagement_SIT0330.Models.Context;
using SchoolManagement_SIT0330.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_SIT0330.Repository.Ropositories
{
    public interface ICountry
    {
        List<CountryModel> GetAllCountryList();

        string CreateCountry(CountryModel countryModel);

        CountryModel EditUserModel(int id);

        int PostCountryData(CountryModel countryModel);
        Country DeleteCountry(int id);
    }
}
