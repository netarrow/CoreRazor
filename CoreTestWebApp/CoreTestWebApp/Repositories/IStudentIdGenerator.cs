using CoreTestWebApp.Models;

namespace CoreTestWebApp.Repositories
{
    public interface IStudentIdGenerator
    {
        long GenerateIdForStudent(Student student);     
    }
}