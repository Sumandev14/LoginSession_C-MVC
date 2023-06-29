using SchoolManagement_380.Models.DbContext;
using SchoolManagement_380.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_380.Helpers.Helpers
{
    
    public class StateHelper
    {
        public static States stateCreae(StateModel stateModel)
        {
            States states = new States()
            {
                CountryId = stateModel.CountryId,
                StateId = stateModel.StateId,
                StateName = stateModel.StateName
            };
            return states;
        }

        public static StateModel getState(States states)
        {
            StateModel stateModel = new StateModel()
            {
                CountryId = (int)states.CountryId,
                StateId = states.StateId,
                StateName = states.StateName
            };
            return stateModel;
        }
    }
}
