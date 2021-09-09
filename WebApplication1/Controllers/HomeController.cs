using ClassLibrary1;
using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Person()
        {
            var a = new Person();
            ViewBag.Message = $"Person: {a.GetName()}, versie {a.GetVersion()}";
            return View();
        }

        public ActionResult Number()
        {
            var a = new AccountNumber();
            ViewBag.Message = $"Number: {a.GetAccountNumber()}, versie {a.GetVersion()}";
            return View();
        }
    }
}