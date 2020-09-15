using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilalAshna.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Resturant Web-Application description:";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "My contact:";

            return View();
        }
    }
}