
using SchoolManagement_SIT0330.Models.Context;
using SchoolManagement_SIT0330.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_SIT0330.Helpers.Helpers
{
    public class StateHelpers
    {
       
        public static List<State> BindStates(List<StateModel> stateModel1)
        {
            try
            {
                List<State> stateList = new List<State>();
                foreach (var item in stateModel1)
                {
                    State state = new State();
                    state.StateId = item.StateId;
                    state.StateName = item.StateName;
                    state.CountryId = item.CountryId;
                    stateList.Add(state);
                }

                return stateList;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public static List<StateModel> BindCountryModel(List<State> state)
        {
            try
            {
                List<StateModel> stateModelList = new List<StateModel>();
                foreach (var item in state)
                {
                    StateModel stateModel = new StateModel();
                    stateModel.StateId = item.StateId;
                    stateModel.StateName = item.StateName;
                    stateModel.CountryId = item.CountryId;
                    stateModel.CountryName = item.Country.CountryName;
                    stateModelList.Add(stateModel);
                }

                return stateModelList;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public static State convertToStateModel(StateModel stateModel)
        {
           
            State state = new State();
            state.StateId = stateModel.StateId;
            state.StateName = stateModel.StateName;
            state.CountryId = stateModel.CountryId;
            
            return state;
            
        }
    }
}


