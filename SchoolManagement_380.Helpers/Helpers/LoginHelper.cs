using SchoolManagement_380.Models.DbContext;
using SchoolManagement_380.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_380.Helpers.Helpers
{
    public class LoginHelper
    {
        public static stdRegistration CreateLog(LoginModel loginModel)
        {
            using(Sandhya_380Entities _DbReg = new Sandhya_380Entities())
            {
                stdRegistration stdReg = new stdRegistration()
                {
                    Email = loginModel.Email,
                    Password = loginModel.Password
                };
                return stdReg;
            }
        }
    }
}
