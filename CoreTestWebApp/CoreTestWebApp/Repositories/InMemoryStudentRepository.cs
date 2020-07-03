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
            return students;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }
    }
}