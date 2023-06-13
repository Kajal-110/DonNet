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
    public class CountryServices : ICountry
    {
        KajalPatel_SIT0330Entities _context = new KajalPatel_SIT0330Entities();

        public string CreateCountry(CountryModel countryModel)
        {
            try
            {
                Country country = new Country();
                country = CountryHelpers.convertToCountryModel(countryModel);
                if (country != null)
                {
                    _context.Countries.Add(country);
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


        public List<CountryModel> GetAllCountryList()
        {
            try
            {

                List<Country> country = new List<Country>();
                List<CountryModel> countryModels = new List<CountryModel>();
                country = _context.Countries.ToList();
                if (country != null && country.Count > 0)
                {
                    countryModels = CountryHelpers.BindCountryModel(country);
                }
                return countryModels;
            }
            catch (Exception e)
            {

                throw e;
            }


        }

        public CountryModel EditUserModel(int id)
        {
            Country country;
            country = _context.Countries.Find(id);

            CountryModel countryModel = CountryHelpers.EditCountry(country);
            return countryModel;
        }


        public int PostCountryData(CountryModel countryModel)
        {
            try
            {


                Country aa = CountryHelpers.convertToCountryModel(countryModel);
                _context.Entry(aa).State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();
                return 1;

            }
            catch (Exception e)
            {
                throw e;
            }


        }

        public Country DeleteCountry(int id)
        {
            var deleteCountry = _context.Countries.Find(id);
            if (deleteCountry != null)
            {
                var delete = _context.Countries.Remove(deleteCountry);
                _context.SaveChanges();
                return delete;

            }
            else
            {
                return null;
            }
        }
    }
}


