using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio.Mvc;


namespace SsnDashBoard.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
                return View();
        }

        private ActionResult AdminView()
        {
            ViewBag.Message = "Supervisor Safety Net: supporting GP Registrars in practice";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Support for Supervisor Safety Net can be found at:";
            return View();
        }
    }
}