using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TestWebApplication.Models;

namespace TestWebApplication.Controllers
{
    //[Authorize(Roles ="Admin")]
    public class ContactsAjaxController : Controller
    {
        private TestModel_new db = new TestModel_new();

        // GET: ContactsAjax
        public async Task<ActionResult> Index()
        {
           // if ((string)Session[Utilites.SessionString.username]!=null)
            {
                HttpCookie cookie = new HttpCookie("Test");
                cookie.Value = "Hello this is from contacts ajax!";
                cookie.Expires.AddMinutes(4);
                this.ControllerContext.HttpContext.Response.Cookies.Add(cookie);
                return View(await db.Contacts.ToListAsync());
            }

            //return RedirectToAction("Login", "CustomUser");
        }


        public async Task<ActionResult> Index_Grid()
        {
            return View(await db.Contacts.ToListAsync());
        }

        // GET: ContactsAjax/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = await db.Contacts.FindAsync(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return PartialView(contact);
        }

        // GET: ContactsAjax/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: ContactsAjax/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,Contact_Number,Address")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Contacts.Add(contact);
                await db.SaveChangesAsync();
                return View("Index");
            }

            return View("Index");
        }

        // GET: ContactsAjax/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = await db.Contacts.FindAsync(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return PartialView(contact);
        }

        // POST: ContactsAjax/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,Contact_Number,Address")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contact).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(contact);
        }

        // GET: ContactsAjax/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = await db.Contacts.FindAsync(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return PartialView(contact);
        }

        // POST: ContactsAjax/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Contact contact = await db.Contacts.FindAsync(id);
            db.Contacts.Remove(contact);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
