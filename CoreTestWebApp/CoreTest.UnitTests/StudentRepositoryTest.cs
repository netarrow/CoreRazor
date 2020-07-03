using CoreTestWebApp.Models;
using CoreTestWebApp.Repositories;
using NUnit.Framework;

namespace CoreTest.UnitTests
{
    public class StudentRepositoryTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void StudentRepository_GetStudents_WhenRepoIsEmpty_ReturnsNoStudents()
        {
            // arrange
            IStudentRepository repo = new InMemoryStudentRepository();

            // act
            var students = repo.GetStudents();

            // assert
            Assert.AreEqual(0, students.Count);

        }

        [Test]
        public void StudentRepository_AddingStudent_MustAddStudentToRepo()
        {
            // arrange
            IStudentRepository repo = new InMemoryStudentRepository();
            Student creatingUser = new Student() { LastName = "Pallo", Name = "Pinco" };

            // act
            repo.AddStudent(creatingUser);

            // assert
            var studentsInRepo = repo.GetStudents();
            Assert.AreEqual(1, studentsInRepo.Count);

        }

    }
}