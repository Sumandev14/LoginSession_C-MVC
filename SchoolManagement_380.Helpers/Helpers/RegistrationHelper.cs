using SchoolManagement_380.Models.DbContext;
using SchoolManagement_380.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_380.Helpers.Helpers
{
    public class RegistrationHelper
    {
        public static stdRegistration createRegistration(RegModel regModel)
        {
          
                stdRegistration stdRegistration = new stdRegistration()
                {
                    StdId = regModel.StdId,
                    UserName = regModel.UserName,
                    RegNo = regModel.RegNo,
                    Address = regModel.Address,
                    Email = regModel.Email,
                    Password = regModel.Password,
                    ConFormPassword = regModel.ConFormPassword
                };
                return stdRegistration;
            
        }

        public static RegModel getUserRegistration(stdRegistration stdRegistration)
        {
            RegModel regModelObject = new RegModel()
                {
                    StdId = stdRegistration.StdId,
                    UserName = stdRegistration.UserName,
                    RegNo = stdRegistration.RegNo,
                    Address = stdRegistration.Address,
                    Email = stdRegistration.Email,
                    Password = stdRegistration.Password,
                    ConFormPassword = stdRegistration.ConFormPassword
                };
                return regModelObject;
            
        }

        //public static List<RegModel> ConvertTocustomUsers(List<stdRegistration> RegList)
        //{
        //    try
        //    {
        //        List<RegModel> customList = new List<RegModel>();
        //        foreach (var item in RegList)
        //        {
        //            RegModel objList = new RegModel();
        //            objList.UserName = item.UserName;
        //            objList.RegNo = item.RegNo;
        //            objList.Address = item.Address;
        //            objList.Email = item.Email;
        //            objList.Password = item.Password;
        //            objList.RoleName = item.RegNo;
        //        }
        //        return customList;
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}
    }
}
