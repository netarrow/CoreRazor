using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreTestWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreTestWebApp.Controllers
{
    public class ClassroomController : Controller
    {
        public IActionResult Index()
        {
            // todo il controller dovrà richiedere i dati ad un oggetto esterno, di cui ignora
            // l'implementazione

            var model = new Classroom();
            model.Students.Add(new Student() { LastName = "Pallo", Name = "Pinco"});
            model.Students.Add(new Student() { LastName = "Mario", Name = "Rossi"});

            return View(model);
        }
    }
}