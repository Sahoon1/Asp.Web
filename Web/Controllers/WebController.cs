using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class WebController : Controller
    {
        // GET: Web
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult service()
        {
            return View();
        }
        public ActionResult portfolio()
        {
            return View();
        }
        public ActionResult starter()
        {
            return View();
        }
    }
}