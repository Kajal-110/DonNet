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
    public class CityServices: ICity
    {
        KajalPatel_SIT0330Entities _context = new KajalPatel_SIT0330Entities();

        public string CreateCity(CityModel cityModel)
        {
            try
            {
                City city = new City();
                

                city = CityHelpers.convertToCityModel(cityModel);   
                if (city != null)
                {
                    _context.Cities.Add(city);
                    _context.SaveChanges();
                    return "Success";
                }
                else
                {
                    return "Fail";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Country> GetALLCountry()
        {
            List<Country> countries = _context.Countries.ToList();
            return (countries);
        }

        public List<State> GetAllState( int CountryId)
        {
            List<State> states = _context.States.Where(x => x.CountryId == CountryId).ToList();
            return states;
        }

        public List<City> GetAllCity(int StateId)
        {
            List<City> cities = _context.Cities.Where(x => x.StateId == StateId).ToList();
            return cities;
        }

        public List<CityModel> GetAllCityList()
        {
            try
            {

                List<CityModel> cityModelList = new List<CityModel>();
                List<City> cities = new List<City>();
                cities = _context.Cities.ToList();
                if(cities != null && cities.Count > 0)
                {
                    cityModelList = CityHelpers.BindCityModel(cities);
                    return cityModelList;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {

                throw e;
            }

        }
    }
}
