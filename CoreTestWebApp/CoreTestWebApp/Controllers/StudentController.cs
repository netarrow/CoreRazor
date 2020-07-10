using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreTestWebApp.Models;
using CoreTestWebApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CoreTestWebApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _repository;

        public StudentController(IStudentRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult AddForm()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EditForm(long studentId)
        {
            var student = _repository.GetStudentById(studentId);
                    
            return View(student);
        }

        [HttpPost]
        public IActionResult EditStudent(Student newStudent)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.AddStudent(student);
                }
                catch (InvalidOperationException ex)
                {
                    ModelState.AddModelError("DuplicatedCF", "Non è possibile inserire studenti con codice fiscale duplicato"); 
                    // log
                    return View("AddForm");
                }

                return RedirectToAction("Index", "Classroom");
            }
            else
                return View("AddForm");

        }

    }
}