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
    }
}