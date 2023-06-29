using SchoolManagement_380.Models.DbContext;
using SchoolManagement_380.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_380.Repository.Repository
{
    public interface IRegistrationRepository
    {
        IEnumerable<stdRegistration> GetAllData();
        bool Create(RegModel regModel, int? id);

        RegModel getUserById(int? id);

        void DeleteStudent(int id);
    }
}
