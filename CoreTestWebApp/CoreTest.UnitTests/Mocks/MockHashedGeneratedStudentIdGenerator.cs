using CoreTestWebApp.Models;
using CoreTestWebApp.Repositories;

namespace CoreTest.UnitTests.Mocks
{
    public class MockHashedGeneratedStudentIdGenerator : IStudentIdGenerator    
    {
        public long GenerateIdForStudent(Student student)
        {
            return (student.LastName + student.Name).GetHashCode();
        }
    }
}