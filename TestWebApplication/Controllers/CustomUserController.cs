using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestWebApplication.Models;
namespace TestWebApplication.Controllers
{
    public class CustomUserController : Controller
    {
        RemitSystem_Northwind_v1Entities db = new RemitSystem_Northwind_v1Entities();
        // GET: CustomUser
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(CustomRegisterViewModel data)
        {
            if (ModelState.IsValid)
            {
                //register ko code
                UserTable ut = new UserTable();
                ut.EmailAddress = data.Email;
                ut.Password = data.Password;
                ut.LastLoginDate = DateTime.Now;

                db.UserTables.Add(ut);
                db.SaveChanges();

                return View("Login");
            }

            return View(data);
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(CustomLoginModel data)
        {
            if (ModelState.IsValid)
            {
                //login
                var ut = db.UserTables.Where(p => p.EmailAddress == data.Email).FirstOrDefault();

                if (ut==null)
                {
                    ModelState.AddModelError("UserNotExists", "User does not exists");
                    return View(data);
                }

                if (ut.Password!=data.Password)
                {
                    ModelState.AddModelError("PasswordNotMatched", "Password does not match.");
                    return View(data);
                }

                //adding session once the authentication is done.
                Session.Add(Utilites.SessionString.username, ut.EmailAddress);
                Session.Add(Utilites.SessionString.Role, ut.Role);
                Session.Add(Utilites.SessionString.LastLoginDate, ut.LastLoginDate);
                //updating last login date in user table
                ut.LastLoginDate = DateTime.Now;
                db.Entry(ut).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index", "Home");
            }
            return View(data);
        }
    }
}