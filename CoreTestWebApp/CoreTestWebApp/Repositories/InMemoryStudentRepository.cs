using System;
using System.Collections.Generic;
using CoreTestWebApp.Models;

namespace CoreTestWebApp.Repositories
{
    public class InMemoryStudentRepository : IStudentRepository
    {
        private readonly IStudentIdGenerator idGenerator;
        private static List<Student> students;

        public InMemoryStudentRepository(IStudentIdGenerator idGenerator)
        {
            this.idGenerator = idGenerator;
            students = new List<Student>();
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public void AddStudent(Student student)
        {
            student.StudentId = this.idGenerator.GenerateIdForStudent(student);
            students.Add(student);
        }
    }
}