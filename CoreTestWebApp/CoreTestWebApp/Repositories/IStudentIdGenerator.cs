using CoreTestWebApp.Models;

namespace CoreTestWebApp.Repositories
{
    public interface IStudentIdGenerator
    {
        int GenerateIdForStudent(Student student);  
    }
}