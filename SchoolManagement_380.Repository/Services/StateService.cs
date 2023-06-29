using SchoolManagement_380.Helpers.Helpers;
using SchoolManagement_380.Models.DbContext;
using SchoolManagement_380.Models.Models;
using SchoolManagement_380.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_380.Repository.Services
{
    public class StateService : IStateRepository
    {
        Sandhya_380Entities6 _Dbcsc = new Sandhya_380Entities6();

        //List State
        public IEnumerable<state_country_Result> getStateCountryList()
        {
            IEnumerable<state_country_Result> stateCountry = _Dbcsc.state_country().ToList();
            return stateCountry;
        }
        //Add state
         public bool AddState(StateModel stateModel, int? id)
        {
            try
            {
                States states = StateHelper.stateCreae(stateModel);
                if (states != null)
                {
                    if(id == 0)
                    {
                        _Dbcsc.States.Add(states);
                        _Dbcsc.SaveChanges();
                        return true;
                    }
                    else
                    {
                        _Dbcsc.Entry(states).State = System.Data.Entity.EntityState.Modified;
                        _Dbcsc.SaveChanges();
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
         }

        public StateModel GetStateById(int? id)
        {
            States states = _Dbcsc.States.Where(x => x.StateId == id).FirstOrDefault();
            StateModel stateModel = StateHelper.getState(states);
            return stateModel;
        }

    

        //Delete State
        public void deleteState(int id)
        {
            var deleteId = _Dbcsc.States.Find(id);
            _Dbcsc.States.Remove(deleteId);
            _Dbcsc.SaveChanges();
        }
    }
}
