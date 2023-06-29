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
    public class LoginService : ILoginRepository
    {
        Sandhya_380Entities _dbContext = new Sandhya_380Entities();
        public stdRegistration CreateLogin(LoginModel loginModel)
        {
            try
            {
                var loginList = _dbContext.stdRegistration.ToList();

                var result = loginList.Find(x => x.Email == loginModel.Email);
                if (result != null)
                {
                    if (result.Password == loginModel.Password)
                    {

                        return result;
                    }
                    else
                    {
                        return null;
                    }
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
