using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreTestWebApp.Models;
using CoreTestWebApp.Repositories;
using CoreTestWebApp.Repositories.Database;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace CoreTest.IntegrationTest
{
    public class EfStudentRepositoryIntegrationTest
    {
        private const string testConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentDbIntegration;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        [TearDown]
        public void Clear()
        {
            using (StudentContext ctx = new StudentContext(testConnectionString))
            {
                ctx.Database.ExecuteSqlCommand("TRUNCATE TABLE [Students]");
            }
        }

        [Test]
        public void EfStudentRepository_GetStudents_OnEmptyDb_MustBeEmpty()
        {
            // arrange
            IStudentRepository repo = new EfStudentRepository(testConnectionString);

            // act
            var students = repo.GetStudents();

            // assert
            Assert.AreEqual(0, students.Count);
        }

        [Test]
        public void StudentRepository_AddingStudent_MustAddStudentToRepo()
        {
            // arrange
            IStudentRepository repo = new EfStudentRepository(testConnectionString);
            Student creatingUser = new Student() { LastName = "Pallo", Name = "Pinco", CF = "CF" };

            // act
            repo.AddStudent(creatingUser);

            // assert
            var studentsInRepo = repo.GetStudents();
            Assert.AreEqual(1, studentsInRepo.Count);

        }
    }
}
