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
    public class CoupenService : ICoupanInterface
    {
        Sandhya_380Entities9 _dbTest = new Sandhya_380Entities9();

      
        public CouponCode GetCoupenDetail(string str)
        {
            return _dbTest.CouponCode.FirstOrDefault(c => c.Code == str);
        }
    }
}
