using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreTestWebApp.Repositories;
using CoreTestWebApp.Repositories.Database;
using NUnit.Framework;

namespace CoreTest.IntegrationTest
{
    public class EfStudentRepositoryIntegrationTest
    {
        private const string testConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentDbIntegration;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        [Test]
        public void EfStudentRepository_GetStudents_OnEmptyDb_MustBeEmpty()
        {
            IStudentRepository repo = new EfStudentRepository(testConnectionString);
            var students = repo.GetStudents();

            Assert.AreEqual(0, students.Count); 
        }
    }
}
