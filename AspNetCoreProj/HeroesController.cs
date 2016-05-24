﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreProj {
    [Route("Heroes/[action]")]
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
        public ActionResult Index() {
            return View("Index");
        }

        [HttpGet]
        public ActionResult Heroes() {
            return View("Index");
        }

        [HttpGet]
        public ActionResult Dashboard() {
            return View("Index");
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Hero> GetList() {
            return new Hero[] {
                new Hero(21, "Cosmo-Bug"),
                new Hero(22, "Monsterkid"),
                new Hero(23, "Grenadine"),
                new Hero(24, "Night Wizard")
            };
        }
    }
}
