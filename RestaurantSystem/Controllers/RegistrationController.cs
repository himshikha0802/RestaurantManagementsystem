
using RestaurantSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantSystem.Controllers
{
    [AllowAnonymousAttribute]
    public class RegistrationController : Controller
    {
        
        // GET: Registration
        ResEntities db = new ResEntities();

        public ActionResult Index()
        {
            var list = db.Table_new.ToList();
            return View(list);
        }

   
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(Table_new Table_New)
        {
            try
            { 
                if (ModelState.IsValid)
                {
                    //throw new Exception("Test Flashbag");
                    db.Table_new.Add(Table_New);
                    db.SaveChanges();
                    FlashBag.setMessage(true, "Saved Successfully");
                    //return RedirectToAction("login","Account");
                   
                }
                else
                {
                    throw new Exception("Invalid Model");
                }
            }
            catch(Exception ex)
            {
                //ModelState.AddModelError("", ex);
                FlashBag.setMessage(false, ex.InnerException != null ? ex.InnerException.Message : ex.Message);
            }
            return View(Table_New);
        }
        public ActionResult Delete(int id)
        {
            Table_new Table_new = db.Table_new.Find(id);
            return View(Table_new);
        }
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            Table_new old_data = db.Table_new.Find(id);
            db.Table_new.Remove(old_data);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }


}