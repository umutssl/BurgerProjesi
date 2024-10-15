using BurgerProjesi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BurgerProjesi.Entities;
using BurgerProjesi.Context;


namespace BurgerProjesi.Controllers

{
    public class RegisterController : Controller
    {
        // GET: Register
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin1 admin1)
        {
            context.Admin1s.Add(admin1);
            context.SaveChanges();
            return RedirectToAction("Index", "Login");
        }
    }
}