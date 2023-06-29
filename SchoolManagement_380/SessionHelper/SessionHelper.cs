using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagement_380.SessionHelper
{
    public class SessionHelper
    {
        public static string Email
        {
            get
            {
                return HttpContext.Current.Session["Email"] == null ? "" : (string)HttpContext.Current.Session["Email"];
            }
            set
            {
                HttpContext.Current.Session["Email"] = value;
            }
        }
    }
}
