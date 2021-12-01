using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_proj.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index(int? id)
        {
            if(id == null)
            {
                ViewBag.Message = "ID is null";
                return View();
            }
            return Json(new { name = "Emin", surname = "Eliyev", Age = 25 });
        }
    }
}
