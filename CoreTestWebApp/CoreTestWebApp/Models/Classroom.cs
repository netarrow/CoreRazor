using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreTestWebApp.Models
{
    public class Classroom
    {
        public Classroom()
        {
            Students = new List<Student>();
        }

        public List<Student> Students { get; set; } 
    }
}
