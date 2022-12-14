using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApplication.LanguageProvider.Classes;

namespace MVCApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult ChangeLanguage(int lang)
        {
            ChangeMessageProvider changeMessageProvider = new ChangeMessageProvider();

            var messages = changeMessageProvider.SetLanguage(lang);
            ViewBag.Message = "Your contact page.";
            return RedirectToAction("Index","Home", messages);
        }
    }
}