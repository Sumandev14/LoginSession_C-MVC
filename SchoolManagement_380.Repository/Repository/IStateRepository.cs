using SchoolManagement_380.Models.DbContext;
using SchoolManagement_380.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_380.Repository.Repository
{
    public interface IStateRepository
    {
        IEnumerable<state_country_Result> getStateCountryList();

        bool AddState(StateModel stateModel, int? id);


        StateModel GetStateById(int? id);

        void deleteState(int id);
    }
}
