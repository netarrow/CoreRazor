using System;
using System.Collections.Generic;
using System.Linq;
using CoreTestWebApp.Models;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Internal.Account;
using Microsoft.EntityFrameworkCore.Internal;

namespace CoreTestWebApp.Repositories
{
    public class InMemoryStudentRepository : IStudentRepository
    {
        private readonly IStudentIdGenerator idGenerator;
        private static List<Student> students;

        public InMemoryStudentRepository(IStudentIdGenerator idGenerator)
        {
            this.idGenerator = idGenerator;
            if(students == null) students = new List<Student>();
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public void AddStudent(Student student)
        {
            var conflictingStudent = students.SingleOrDefault(_ => _.CF == student.CF);

            if(conflictingStudent != null)
                throw new InvalidOperationException($"Invalid op. adding duplicate student with CF {student.CF}");

            student.StudentId = this.idGenerator.GenerateIdForStudent(student);
            students.Add(student);
        }
    }
}