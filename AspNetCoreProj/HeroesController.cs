using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreProj {
    [Route("Heroes/GetList")]
    public class HeroesController : Controller {
        public class Hero {
            public int id { get; set; }
            public string name { get; set; }

            public Hero(int id, string name) {
                this.id = id;
                this.name = name;
            }
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Hero> Get() {
            return new Hero[] {
                new Hero(21, "Cosmo-Bug"),
                new Hero(22, "Monsterkid"),
                new Hero(23, "Grenadine"),
                new Hero(24, "Night Wizard")
            };
        }
    }
}
