using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantSystem.Controllers
{
    public class IcecreamController : Controller
    {
        // GET: Icecream
        public ActionResult Index()
        {
            return View();
        }
    }
}