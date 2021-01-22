using limonmali.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace limonmali.Controllers
{
    public class HomeController : Controller
    {
        dbLimonEntities db = new dbLimonEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Hizmetler()
        {
            List<Hizmetler> hizmetler = db.Hizmetler.ToList();

            return PartialView(hizmetler);
        }
        public ActionResult Hakkimizda()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Slider()
        {
            List<Slider> slider = db.Slider.ToList();

            return PartialView(slider);
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}