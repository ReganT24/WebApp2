using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Index");
        }
        // GET: Home
        public ActionResult Section1Index()
        {
            return View("Section1/Index");
        }
    }
}