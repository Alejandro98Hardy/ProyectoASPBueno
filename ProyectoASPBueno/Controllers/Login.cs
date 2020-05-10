using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoASPBueno.Data;
using ProyectoASPBueno.Models;
using System.Data.Entity;
using System.Net;

namespace ProyectoASPBueno.Controllers
{
    public class Login : Controller
    {
        private BDContext db = new BDContext();
        public ActionResult Index()
        {
            return View(db.Subscrips.ToList());
        }
    }

}