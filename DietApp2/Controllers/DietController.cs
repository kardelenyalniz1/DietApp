using DietApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DietApp2.Controllers
{
    public class DietController : Controller
    {
        // GET: Diet
        public ActionResult Index()
        {
            return View(Database.List);
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Diet entity)
        {
            entity.date = DateTime.Now;
            entity.İsCompleted = false;
            Database.Add(entity);
            return View("Index",Database.List);
        }
    }
}