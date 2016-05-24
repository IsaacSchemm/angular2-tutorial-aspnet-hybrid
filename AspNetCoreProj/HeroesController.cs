using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreProj {
    public class HeroesController : Controller {
        public class Hero {
            public int id { get; set; }
            public string name { get; set; }

            public Hero(int id, string name) {
                this.id = id;
                this.name = name;
            }
        }

        [HttpGet]
        [Route("Heroes/Index")]
        public ActionResult Index() {
            return View("Index");
        }

        [HttpGet]
        [Route("Heroes/Heroes")]
        public ActionResult Heroes() {
            return View("Index");
        }

        [HttpGet]
        [Route("Heroes/Dashboard")]
        public ActionResult Dashboard() {
            return View("Index");
        }

        private List<Hero> HEROES = new List<Hero> {
            new Hero(21, "Cosmo-Bug"),
            new Hero(22, "Monsterkid"),
            new Hero(23, "Grenadine"),
            new Hero(24, "Night Wizard"),
            new Hero(25, "White Stripe"),
            new Hero(26, "Quicksand")
        };

        [HttpGet]
        [Route("Heroes/Api")]
        public IEnumerable<Hero> API() {
            return HEROES;
        }

        [HttpGet]
        [Route("Heroes/Api/{id}")]
        public Hero Get(int id) {
            return HEROES.SingleOrDefault(h => h.id == id);
        }

        [HttpPost]
        [Route("Heroes/Api")]
        public Hero Post([FromBody]Hero hero) {
            hero.id = HEROES.Select(h => h.id).Max() + 1;
            HEROES.Add(hero);
            return hero;
        }

        [HttpPut]
        [Route("Heroes/Api/{id}")]
        public Hero Put(int id, [FromBody]Hero hero) {
            HEROES.Single(h => h.id == id).name = hero.name;
            return hero;
        }

        [HttpDelete]
        [Route("Heroes/Api/{id}")]
        public void Delete(int id) {
            HEROES.RemoveAll(h => h.id == id);
        }
    }
}
