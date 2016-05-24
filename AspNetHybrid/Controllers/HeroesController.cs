using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetHybrid.Controllers
{
    public class HeroesController : Controller
    {
        // GET: Heroes
        public ActionResult Index()
        {
            if (Request.Url.AbsolutePath != "/Heroes") {
                return RedirectToAction("Index");
            }
            return View();
        }

        public class Hero {
            public int id;
            public string name;
        }
        
        public ActionResult GetList()
        {
            System.Threading.Thread.Sleep(2000);
            Hero[] array = new Hero[] {
                new Hero { id = 20, name = "Grenadine" },
                new Hero { id = 21, name = "Metalen Meisje" },
                new Hero { id = 22, name = "Monsterkid" },
            };
            return Json(array, JsonRequestBehavior.AllowGet);
        }
    }
}