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
    public class RegistrationService : IRegistrationRepository
    {

        Sandhya_380Entities _dbContext = new Sandhya_380Entities();

        
        public bool Create(RegModel regModel, int? id)
        {
            //stdRegistration createRegistration = SchoolManagement_380.Helpers.Helpers.RegistrationHelper.createRegistration(regModel);
            //_dbContext.stdRegistration.Add(createRegistration);
            //_dbContext.SaveChanges();
            try
            {
                stdRegistration stdRegistration = RegistrationHelper.createRegistration(regModel);
                if(stdRegistration != null)
                {
                    if(id == 0)
                    {
                        _dbContext.stdRegistration.Add(stdRegistration);
                        _dbContext.SaveChanges();
                        return true;
                    }
                    else
                    {
                        _dbContext.Entry(stdRegistration).State = System.Data.Entity.EntityState.Modified;
                        _dbContext.SaveChanges();
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

       

        public IEnumerable<stdRegistration> GetAllData()
        {
            return _dbContext.stdRegistration.ToList();
        }


        public RegModel getUserById(int? id)
        {
            stdRegistration stdRegistration = _dbContext.stdRegistration.Where(x => x.StdId == id).FirstOrDefault();
            RegModel regModel = RegistrationHelper.getUserRegistration(stdRegistration);
            return regModel;

        }

        void IRegistrationRepository.DeleteStudent(int id)
        {
            var deleteid = _dbContext.stdRegistration.Find(id);
            _dbContext.stdRegistration.Remove(deleteid);
            _dbContext.SaveChanges();
        }
    }
}
