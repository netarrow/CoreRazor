using CoreTestWebApp.Models;

namespace CoreTestWebApp.Repositories
{
    public class MockPrefetchedStudentIdGenerator : IStudentIdGenerator
    {
        private readonly long prefetchedStudentId;

        public MockPrefetchedStudentIdGenerator(long prefetchedStudentId)
        {
            this.prefetchedStudentId = prefetchedStudentId;
        }

        public long GenerateIdForStudent(Student student)
        {
            return this.prefetchedStudentId;
        }
    }
}