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
    public class StateServices: IState
    {
        KajalPatel_SIT0330Entities _context = new KajalPatel_SIT0330Entities();

        public List<StateModel> GetAllStateList()
        {
            try
            {

                List<State> state = new List<State>();
                List<StateModel> stateModels = new List<StateModel>();
                state = _context.States.ToList();
                if (state != null && state.Count > 0)
                {
                    stateModels = StateHelpers.BindCountryModel(state);
                }
                return stateModels;
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public List<Country> GetALLCountry()
        {  
            List<Country> countries = _context.Countries.ToList();
            return (countries);
        }

        public string StateCreate(StateModel stateModel)
        {
            try
            {
                
                State state = new State();
                state = StateHelpers.convertToStateModel(stateModel);
                if (state != null)
                {
                    _context.States.Add(state);
                    _context.SaveChanges();
                    return "Success";
                }
                else
                {
                    return "Fail";
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }


        }


    }
}
