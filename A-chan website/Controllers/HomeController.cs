using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using A_chan_website.Models;

namespace A_chan_website.Controllers
{
    public class HomeController : Controller
    {
        AChanDB db = new AChanDB();
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
        public ActionResult Tutorial()
        {
            ViewBag.Message = "Tutorial";
            return View();
        }
        public ActionResult Travel()
        {
            ViewBag.Message = "Travel";
            return View();
        }
        public ActionResult Signin()
        {
            ViewBag.Message = "Signin";
            return View();
        }
        public ActionResult Items()
        {
            ViewBag.Message = "Items";
            var itemlist = db.SanPhams.Take(2).ToList();
            return View(itemlist);
        }

    }
}