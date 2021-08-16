using RestaurantSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantSystem.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        ResEntities db = new ResEntities();
        public ActionResult Index()
        {
            var list = db.Table_staff.ToList();
            return View(list);
        }
        public ActionResult AddNew()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNew(Table_staff Table_staff, HttpPostedFileBase UploadedFile)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Table_staff.Add(Table_staff);
                    db.SaveChanges();
                    FlashBag.setMessage(true, "Saved Successfully");
                    return RedirectToAction("Index");
                }
                else
                {
                    throw new Exception("Invalid Model");
                }
            }
            catch (Exception ex)
            {
                FlashBag.setMessage(false, ex.InnerException != null ? ex.InnerException.Message : ex.Message);
            }
            return View();
        }
        public ActionResult Edit(int id)
        {
            Table_staff Table_staff = db.Table_staff.Find(id);
            return View(Table_staff);
        }
        [HttpPost]
        public ActionResult Edit(Table_staff Table_staff, HttpPostedFileBase UploadedFile)
        {
            Table_staff old_data = db.Table_staff.Find(Table_staff.Staff_ID);
            old_data.StaffName = Table_staff.StaffName;
            old_data.Salary = Table_staff.Salary;
            old_data.Age = Table_staff.Age;
            old_data.Address = Table_staff.Address;
            old_data.Position = Table_staff.Position;
            old_data.Qualification = Table_staff.Qualification;
            old_data.PhoneNum = Table_staff.PhoneNum;
            db.Entry(old_data).State = EntityState.Modified;
            db.SaveChanges();
            FlashBag.setMessage(true, "Saved Successfully");
            return RedirectToAction("Index");

        }
        public ActionResult Delete(int id)
        {
            Table_staff Table_staff = db.Table_staff.Find(id);
            return View(Table_staff);
        }
        [HttpPost]
        public ActionResult DeleteConfirmed(int Staff_ID)
        {
            Table_staff old_data = db.Table_staff.Find(Staff_ID);
            db.Table_staff.Remove(old_data);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}