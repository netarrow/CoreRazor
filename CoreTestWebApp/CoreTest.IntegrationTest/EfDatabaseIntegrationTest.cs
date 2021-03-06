using System.Linq;
using CoreTestWebApp.Repositories.Database;
using NUnit.Framework;

namespace CoreTest.IntegrationTest
{
    public class EfDatabaseIntegrationTest
    {
        private const string testConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentDbIntegration;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void LearningTest_DbContext_Test_Connection_ToDb()
        {
            using (StudentContext ctx = new StudentContext(testConnectionString))
            {
                Assert.IsTrue(ctx.Database.CanConnect());
            }
        }
    }
}