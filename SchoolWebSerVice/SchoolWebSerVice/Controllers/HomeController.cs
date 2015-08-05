using SchoolWebSerVice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolWebSerVice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Messenger = GetHTML.getTKB(GetHTML.makeUrlTKB("3111410094","1"));
            return View();
        }
    }
}
