using SchoolManagement_SIT0330.Models.Context;
using SchoolManagement_SIT0330.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_SIT0330.Helpers.Helpers
{
    public class CityHelpers
    {
        public static List<City> BindCity(List<CityModel> cityModels)
        {
            try
            {
                List<City> citiesList = new List<City>();
                foreach( var item in cityModels)
                {
                    City city = new City();
                    city.CityId = item.CityId;
                    city.CityName = item.CityName;
                    city.StateId = item.StateId;
                    city.CountryId = item.CountryId;
                    citiesList.Add(city);
                }
                return citiesList;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<CityModel> BindCityModel(List<City> cities)
        {
            try
            {
                List<CityModel> cityModelList = new List<CityModel>();
                foreach(var item in cities)
                {
                    CityModel cityModel = new CityModel();
                    cityModel.CityId = item.CityId;
                    cityModel.CityName = item.CityName;
                    cityModel.StateId = item.StateId;
                    cityModel.CountryId = item.CountryId;
                    cityModel.CountryName = item.Country.CountryName;
                    cityModel.StateName = item.State.StateName;
                    cityModelList.Add(cityModel);
                }
                return cityModelList;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public static City convertToCityModel(CityModel cityModel )
        {

            
            City city = new City();
            city.CityId = cityModel.CityId;
            city.CityName = cityModel.CityName;
            city.StateId = cityModel.StateId;
            city.CountryId = cityModel.CountryId;


            return city;

        }
    }
}
