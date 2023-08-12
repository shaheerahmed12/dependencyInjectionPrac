using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using  BL;

namespace dependency.Controllers
{
    public class HomeController : Controller
    {    private IEmployee _employee=null;
        private HomeController(IEmployee employee)
        {
            _employee = employee;
        }
        public ActionResult Index()
        {
            int data = _employee.Get();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}