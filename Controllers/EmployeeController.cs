using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1_WithMVC_1147.Models;

namespace WebApplication1_WithMVC_1147.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            //Employee employee = new Employee();
            //employee.Empno = 1;
            //employee.Name = "Harminder";
            //employee.Address = "Chandigarh";
            //employee.Salary = 100000;
            //Employee employee = new Employee { Empno = 1, Name = "Harminder", Address = "Chandigarh", Salary = 100000 };
            Employee employee = new Employee()
            {
                Empno=1,
                Name="Harminder",
                Address="Chandigarh",
                Salary=100000
            };
            return View();
        }
    }
}