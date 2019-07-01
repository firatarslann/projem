using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projem.Controllers
{
    public class ContectController : Controller
    {
        // GET: Contect
        public ActionResult Index()
        {
            ViewBag.Title = "İletişim";
            return View();
        }
    }
}