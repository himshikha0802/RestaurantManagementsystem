using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantSystem.Helper
{
    public static class SessionHelper//it is static so directly access
    { //to set data session helps,so username can be access anytime
        public static void SetSession(SystemInfoForSession systemInfoForSession)
        {
            HttpContext.Current.Session["SystemInfoForSession"] = systemInfoForSession;  
        }

        public static SystemInfoForSession GetSession()
        {
            return (SystemInfoForSession)HttpContext.Current.Session["SystemInfoForSession"];
        }
    }
}