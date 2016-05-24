using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetHybrid.Controllers
{
    public class HeroesController : Controller
    {
        public ActionResult Index() {
            return View();
        }

        public ActionResult Heroes() {
            return View("Index");
        }

        public ActionResult Dashboard() {
            return View("Index");
        }

        public class Hero {
            public int id;
            public string name;

            public Hero(int id, string name) {
                this.id = id;
                this.name = name;
            }
        }

        private Hero[] HEROES = new Hero[] {
            new Hero(21, "Cosmo-Bug"),
            new Hero(22, "Monsterkid"),
            new Hero(23, "Grenadine"),
            new Hero(24, "Night Wizard"),
            new Hero(25, "White Stripe"),
            new Hero(26, "Quicksand")
        };
        
        public ActionResult GetList() {
            return Json(HEROES, JsonRequestBehavior.AllowGet);
        }
        
        public ActionResult GetHero(int id) {
            return Json(HEROES.SingleOrDefault(h => h.id == id), JsonRequestBehavior.AllowGet);
        }
    }
}