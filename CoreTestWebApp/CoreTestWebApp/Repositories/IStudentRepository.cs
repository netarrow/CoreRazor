using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreTestWebApp.Models;

namespace CoreTestWebApp.Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetStudents();

        void AddStudent(Student student);

    }
}
