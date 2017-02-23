using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TestWebApplication.Models;

namespace TestWebApplication.Controllers
{
    public class ContactsController : Controller
    {
        private TestModel_new db = new TestModel_new();

        // GET: Contacts
        public ActionResult Index(string search="", string field="", bool ascending=true)
        {

                ViewBag.search = search;
                ViewBag.ascending = ascending;

                var data = db.Contacts.Where(x => x.Name.Contains(search) || x.Address.Contains(search) || x.Contact_Number.Contains(search) || x.Id.ToString().Contains(search));

                if (field=="name")
                {
                    if (ascending)
                        data = data.OrderBy(p => p.Name);
                    else
                        data = data.OrderByDescending(p => p.Name);
                }

            var cookie = this.ControllerContext.HttpContext.Request.Cookies["Test"];

            ViewBag.CookieValue = cookie.Value;

                return View(data);


        }

        [HttpPost]

        public ActionResult UploadFile(HttpPostedFileBase file)
        {
            string[] abc = new string[10];
            int i = 0;
            foreach (var item in Request.Form.AllKeys)
            {
                abc[i] = Request.Form[item];
                i++;
            }

            int j = i;

            file.SaveAs(Server.MapPath("~/Images")+"\\"+ file.FileName);

            return View("Index");
        }


        // GET: Contacts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = db.Contacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        // GET: Contacts/Create
        public ActionResult Create()
        {
            var cookie = this.ControllerContext.HttpContext.Request.Cookies["Test"];

            cookie.Expires = DateTime.Now.AddHours(-5);

            this.ControllerContext.HttpContext.Response.Cookies.Add(cookie);

            return View();
        }

        // POST: Contacts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Contact_Number,Address")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Contacts.Add(contact);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contact);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public string Create_New([Bind(Include = "Id,Name,Contact_Number,Address")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Contacts.Add(contact);
                db.SaveChanges();
                return "Successfully Created";
            }

            return "Unable to create";
        }

        // GET: Contacts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = db.Contacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        // POST: Contacts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Contact_Number,Address")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contact).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contact);
        }

        // GET: Contacts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = db.Contacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        // POST: Contacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contact contact = db.Contacts.Find(id);
            db.Contacts.Remove(contact);
            db.SaveChanges();
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
