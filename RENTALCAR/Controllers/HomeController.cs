using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RENTALCAR.Controllers
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

        public ActionResult Giris()
        {
            ViewBag.Message = "Giris Sayfasi";
            return View();
        }

        public ActionResult Hakkimizda()
        {
            ViewBag.Message = "Giris Sayfasi";
            return View();
        }

        public ActionResult Rezervasyon()
        {
            return View();
        }
    }
}