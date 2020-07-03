using CoreTestWebApp.Models;

namespace CoreTestWebApp.Repositories
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