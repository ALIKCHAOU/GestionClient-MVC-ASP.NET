using Gestion_des_clients.Context;
using Gestion_des_clients.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gestion_des_clients.Controllers
{
    public class UserAccountController : Controller
    {
        GestiondesclientsContext db = new GestiondesclientsContext();
        // GET: UserAccount
        public ActionResult Index()
        {
            return View(db.UserAccounts.ToList());
        }

      
        // GET: UserAccount/Register
        public ActionResult Register()
        {
            return View();
        }

        // POST: UserAccount/Register
        [HttpPost]
        public ActionResult Register(UserAccount UserAccount)
        {
          if(ModelState.IsValid)
            { 
                db.UserAccounts.Add(UserAccount);
                db.SaveChanges();
                ModelState.Clear();
                ViewBag.Message = UserAccount.nom + "" + UserAccount.prenom + "registrement  avec succès";
                                           }
            return View();

        }
        // GET
        public ActionResult login()
        {
            return View();
        }
        
        // Post 
        [HttpPost]
        public ActionResult login(UserAccount UserAccount)
        {

            var user = db.UserAccounts.Where(x => x.login == UserAccount.login && x.mot_de_passe == UserAccount.mot_de_passe).FirstOrDefault();
            if(user!= null)
            {    Session["UserID"] = user.id.ToString();
                 Session["Userlogin"] = user.login.ToString();
                 return RedirectToAction("loggIn");
                    }
            else
            {
                ModelState.AddModelError("","LOGIN OU mote de passe sont faux ");
            }
            return View();
        }

        // GET
        public ActionResult loggIn()
        {
            if(Session["UserID"] != null )
            { return View(); }
            else
            { return RedirectToAction("login"); }

        }





















    }
}
