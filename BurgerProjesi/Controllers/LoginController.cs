using BurgerProjesi.Context;
using BurgerProjesi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;


namespace BurgerProjesi.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        BurgerMenuContext context = new BurgerMenuContext();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin1 admin1)
        {
            var values = context.Admin1s.FirstOrDefault(x => x.UserName == admin1.UserName && x.Password == admin1.Password);
            if(values != null)
            {
                FormsAuthentication.SetAuthCookie(values.UserName, false);
                Session["x"]=values.UserName.ToString();
                return RedirectToAction("ProductList", "Product", new { area  = "Admin1" });
            }
            else
            {
                return View();
            }
        }
    }
}