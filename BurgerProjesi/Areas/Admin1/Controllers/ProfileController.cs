using BurgerProjesi.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BurgerProjesi.Context;
using BurgerProjesi.Entities;

namespace BurgerProjesi.Areas.Admin1.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
       BurgerMenuContext conntext=new BurgerMenuContext();
        public ActionResult MyProfileList()
        {
            var UserName = Session["x"];
            var values=conntext.Admin1s.Where(x=>x.UserName==UserName).FirstOrDefault();
            return View(values);
        }
        [HttpPost]
        public ActionResult MyProfileList(BurgerProjesi.Entities.Admin1 admin1)
        {
            var userName=Session["x"];
            var values=conntext.Admin1s.Where(x=> x.UserName==userName).FirstOrDefault();
            values.UserName=admin1.UserName;
            values.Surname=admin1.Surname;
            values.Name=admin1.Name;
            values.Password=admin1.Password;
            values.Email=admin1.Email;
            conntext.SaveChanges();
            return RedirectToAction("Index","Login");
        }
    }
}