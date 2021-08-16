using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantSystem.Controllers
{
    [AllowAnonymous]
    public class TemplateController : Controller
    {
        // GET: Template
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
       
        public ActionResult Chef()
        {
            return View();
        }
        public ActionResult Special()
        {
            return View();
        }
        public ActionResult Menu()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}