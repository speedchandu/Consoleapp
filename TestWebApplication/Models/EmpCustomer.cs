using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestWebApplication.Models;
namespace TestWebApplication.Models
{
    public class EmpCustomer
    {
        public List<Employee> Emp { get; set; }
        public List<Customer> Cust { get; set; }
    }


    public class DashBoardModel
    {
        public int Employees { get; set; }
        public int Customers { get; set; }
        public int Orders { get; set; }
    }
}