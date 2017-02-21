using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestWebApplication.Models;
namespace TestWebApplication.Controllers
{
    public class EmployeeController : Controller
    {
        RemitSystem_Northwind_v1Entities db = new RemitSystem_Northwind_v1Entities();
        // GET: Employee
        public ActionResult Index()
        {
            DashBoardModel Dbm = new DashBoardModel();
            Dbm.Customers = db.Customers.Count();
            Dbm.Employees = db.Employees.Count();
            Dbm.Orders = db.Employees.Count();
            return View(Dbm);
        }
    }
}