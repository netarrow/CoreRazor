using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreTestWebApp.Models;
using CoreTestWebApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoreTestWebApp.Controllers
{
    public class ClassroomController : Controller
    {
        private readonly IStudentRepository _repository;

        public ClassroomController(IStudentRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var model = new Classroom();

            model.Students = _repository.GetStudents();

            return View(model);
        }
    }
}