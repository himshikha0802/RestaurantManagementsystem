using RestaurantSystem.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantSystem.Controllers
{
   
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            SystemInfoForSession SessionData = SessionHelper.GetSession();
            var UserName = SessionData.UserName;
            var UserId = SessionData.UserId;
            return View();
        }
       
       
    }
}