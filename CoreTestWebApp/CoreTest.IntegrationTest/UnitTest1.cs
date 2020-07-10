using System.Linq;
using CoreTestWebApp.Repositories.Database;
using NUnit.Framework;

namespace CoreTest.IntegrationTest
{
    public class EfDatabaseIntegration
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DbContext_Test_Connection_ToDb()
        {
            using (StudentContext ctx = new StudentContext())
            {
                var students = ctx.Students.ToList();
                Assert.AreEqual(1, students.Count);
            }
        }
    }
}