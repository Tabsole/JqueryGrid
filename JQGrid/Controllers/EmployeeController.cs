using JQGrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JQGrid.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetData()
        {
            using (DBModel db = new DBModel())
            {
                var employeeList = db.Employees.ToList<Employee>();
                return Json(new { rows = employeeList }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}