using CoreTestWebApp.Models;
using CoreTestWebApp.Repositories;

namespace CoreTest.UnitTests.Mocks
{
    public class MockPrefetchedStudentIdGenerator : IStudentIdGenerator  
    {
        private readonly int prefetchedStudentId;   

        public MockPrefetchedStudentIdGenerator(int prefetchedStudentId)
        {
            this.prefetchedStudentId = prefetchedStudentId; 
        }

        public int GenerateIdForStudent(Student student)
        {
            return this.prefetchedStudentId;
        }
    }
}