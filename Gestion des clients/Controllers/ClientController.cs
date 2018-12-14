using Gestion_des_clients.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gestion_des_clients.Models;
using System.Data.Entity;

namespace Gestion_des_clients.Controllers
{
    public class ClientController : Controller
    {
        GestiondesclientsContext db = new GestiondesclientsContext();
        // GET: Client
        public ActionResult Index()
        {
            return View(db.clients.ToList()); 
        }


        // GET: Client/Details/5
        public ActionResult Details(int id)
        {    
            return View(db.clients.Where(x => x.id == id).FirstOrDefault());
        }

        // GET: Client/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Client/Create
        [HttpPost]
        public ActionResult Create( Client client)
        {
            try
            {
                // TODO: Add insert logic here
                db.clients.Add(client);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Client/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.clients.Where(x => x.id == id).FirstOrDefault());
        }

        // POST: Client/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Client client)
        {
            try
            {
                // TODO: Add update logic here
                db.Entry(client).State = EntityState.Modified;
                db.SaveChanges();



                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Client/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.clients.Where(x => x.id == id).FirstOrDefault());
        }

        // POST: Client/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Client client)
        {
            try
            {
                // TODO: Add delete logic here
                Client clientdelete = db.clients.Where(x => x.id == id).FirstOrDefault();
                db.clients.Remove(clientdelete);
                db.SaveChanges();


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
