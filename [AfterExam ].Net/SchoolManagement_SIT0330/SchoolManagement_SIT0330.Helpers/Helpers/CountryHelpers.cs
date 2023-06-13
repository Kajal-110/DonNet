using SchoolManagement_SIT0330.Models.Context;
using SchoolManagement_SIT0330.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_SIT0330.Helpers.Helpers
{
    public class CountryHelpers
    {
        public static List<Country> BindCountry(List<CountryModel> countryModel1)
        {
            try
            {
                 List<Country> countryList = new List<Country>();
                 foreach( var item in countryModel1)
                 {
                    Country country = new Country();
                    country.CountryId = item.CountryId;
                    country.CountryName = item.CountryName;
                    countryList.Add(country);
                 }
                    return countryList;

            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public static List<CountryModel> BindCountryModel(List<Country> country)
        {
            try
            {
                List<CountryModel> countryModelList = new List<CountryModel>();
                foreach( var item in country)
                {
                    CountryModel countryModel = new CountryModel();
                    countryModel.CountryId = item.CountryId;
                    countryModel.CountryName = item.CountryName;
                    countryModelList.Add(countryModel);

                }
                return countryModelList;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static Country convertToCountryModel(CountryModel countryModel)
        {
           
            Country country = new Country();
            country.CountryId = countryModel.CountryId;
            country.CountryName = countryModel.CountryName;

            return country;
        }

        public static CountryModel EditCountry( Country country)
        {
            CountryModel countryModel = new CountryModel();
            countryModel.CountryId = country.CountryId;
            countryModel.CountryName = country.CountryName;
            return countryModel;
        }
    }
}


