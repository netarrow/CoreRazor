using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreTestWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreTestWebApp.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult AddForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            if (!ModelState.IsValid)
            {
                var test = "error";
            }

            return View("AddForm");
        }

    }
}