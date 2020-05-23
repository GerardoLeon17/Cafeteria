using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cafeteria.Models;

namespace Cafeteria.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            

            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Principal");
            }

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

        public ActionResult Menu()
        {
            

            ViewBag.Message = "Your Menu page.";



            return View( db.Products.ToList());
        }

        public ActionResult Orden()
        {
            
            return View( db.Orders.ToList());
        }




    }
}