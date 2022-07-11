using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {

            List<Department> departments = new List<Department>();
            departments.Add(new Department { Id = 1,Name = "Electronics" }) ;
            departments.Add(new Department { Id = 1,Name = "Fashion" }) ;
            return View(departments);
        }
    }
}
