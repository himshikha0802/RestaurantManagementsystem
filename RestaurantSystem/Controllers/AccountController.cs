using RestaurantSystem.Helper;
using RestaurantSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantSystem.Controllers
{
    public class AccountController : Controller
    {
        // GET: Login
        ResEntities db = new ResEntities();
     [AllowAnonymousAttribute]
        public ActionResult Index()
        {
          
            return View();
        }

        [AllowAnonymousAttribute]
        public ActionResult Login()
        {
            return View();
        }
        [AllowAnonymousAttribute]
        [HttpPost]
        public ActionResult Login(Table_new Table_new)
        {
            try
            {
                var check_old_data = db.Table_new.Where(x => x.UserName == Table_new.UserName && x.Password == Table_new.Password).FirstOrDefault();
                if (check_old_data != null)
                {
                    SystemInfoForSession sessionData = new SystemInfoForSession();
                    sessionData.UserId = check_old_data.UserId;
                    sessionData.UserName = check_old_data.UserName;
                    Session["SystemInfoForSession"] = sessionData;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    throw new Exception("A user with this username or password does'nt exist");
                }
            }

            catch (Exception ex)
            {
            
                FlashBag.setMessage(false, ex.InnerException != null ? ex.InnerException.Message : ex.Message);
            }
            return View();
        }
           
            

            //if(LoginVM.UserName=="shikha" && LoginVM.Password == "shikha")
            //{
            //    SystemInfoForSession sessionData = SessionHelper.GetSession();
            //    sessionData.UserId = 1;
            //   sessionData.UserName = "Faijan";
            //    Session["SystemInfoForSession"] = sessionData;
            //        return RedirectToAction("Index", "Home");
            //}
            
        
        public ActionResult LogOut()
        {
            Session["SystemInfoForSession"] = null;
            return RedirectToAction("login","Account");
        }
      
    }
}