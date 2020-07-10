using System.Collections.Generic;
using System.Linq;
using CoreTestWebApp.Models;

namespace CoreTestWebApp.Repositories.Database
{
    public class EfStudentRepository : IStudentRepository
    {
        private readonly string _connectionString;

        public EfStudentRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Student> GetStudents()
        {
            using (StudentContext ctx = new StudentContext(_connectionString))
            {
                return ctx.Students.ToList();
            }
        }

        public void AddStudent(Student student)
        {
            using (StudentContext ctx = new StudentContext(_connectionString))
            {
                ctx.Students.Add(student);

                ctx.SaveChanges();
            }
        }

        public Student GetStudentById(long studentId)
        {
            throw new System.NotImplementedException();
        }

        public void EditStudent(Student updatedStudent)
        {
            throw new System.NotImplementedException();
        }
    }
}