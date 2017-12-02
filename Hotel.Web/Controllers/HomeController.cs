using Hotel.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hotel.Web.DB;

namespace Hotel.Web.Controllers
{
    public class HomeController : Controller
    {
        private HotelDbContext db = new HotelDbContext();

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Data()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserData user)
        {
            if(ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Detail");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Detail()
        {
            return View();
        }
    }
}
