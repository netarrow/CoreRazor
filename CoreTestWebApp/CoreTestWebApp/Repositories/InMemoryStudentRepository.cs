using System;
using System.Collections.Generic;
using CoreTestWebApp.Models;

namespace CoreTestWebApp.Repositories
{
    public class InMemoryStudentRepository : IStudentRepository
    {
        private static List<Student> students; 

        public InMemoryStudentRepository()
        {
            students = new List<Student>();
        }

        public List<Student> GetStudents()
        {
            students.Add(new Student() { LastName = "Pallo", Name = "Pinco"});
            students.Add(new Student() { LastName = "A", Name = "B"});
            students.Add(new Student() { LastName = "C", Name = "D"});

            return students;
        }

        public void AddStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}