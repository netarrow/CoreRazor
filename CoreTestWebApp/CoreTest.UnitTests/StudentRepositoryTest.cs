using System;
using System.Linq;
using CoreTest.UnitTests.Mocks;
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

        [TearDown]
        public void Clear()
        {
            var repo = new InMemoryStudentRepository(new MockPrefetchedStudentIdGenerator(1));
            repo.GetStudents().Clear();
        }

        [Test]
        public void StudentRepository_GetStudents_WhenRepoIsEmpty_ReturnsNoStudents()
        {
            // arrange
            IStudentRepository repo = new InMemoryStudentRepository(new MockPrefetchedStudentIdGenerator(1));

            // act
            var students = repo.GetStudents();

            // assert
            Assert.AreEqual(0, students.Count);

        }

        [Test]
        public void StudentRepository_AddingStudent_MustAddStudentToRepo()
        {
            // arrange
            IStudentRepository repo = new InMemoryStudentRepository(new MockPrefetchedStudentIdGenerator(1));
            Student creatingUser = new Student() { LastName = "Pallo", Name = "Pinco" };

            // act
            repo.AddStudent(creatingUser);

            // assert
            var studentsInRepo = repo.GetStudents();
            Assert.AreEqual(1, studentsInRepo.Count);

        }

        [Test]
        public void StudentRepository_AddingStudent_LastNameNameAndStudentId()
        {
            // arrange
            IStudentRepository repo = new InMemoryStudentRepository(new MockPrefetchedStudentIdGenerator(12345));
            Student creatingUser = new Student() { LastName = "Pallo", Name = "Pinco" };

            // act
            repo.AddStudent(creatingUser);

            // assert
            var studentsInRepo = repo.GetStudents();
            Assert.AreEqual("Pallo", studentsInRepo.Single().LastName);
            Assert.AreEqual("Pinco", studentsInRepo.Single().Name);
            Assert.AreEqual(12345, studentsInRepo.Single().StudentId);
        }

        [Test]
        public void StudentRepository_AddingTwoStudentStudent_TwoStudentWithTwoStudentId()
        {
            // arrange
            IStudentRepository repo = new InMemoryStudentRepository(new MockHashedGeneratedStudentIdGenerator());
            Student firstStudent = new Student() { LastName = "Pallo", Name = "Pinco", CF ="TestCF" };
            Student secondStudent = new Student() { LastName = "Caio", Name = "Tizio", CF = "OherTestCF" };

            // act
            repo.AddStudent(firstStudent);
            repo.AddStudent(secondStudent);

            // assert
            var studentsInRepo = repo.GetStudents();
            Assert.AreNotEqual(studentsInRepo.ElementAt(0).StudentId, studentsInRepo.ElementAt(1).StudentId);
        }

        [Test]
        public void StudentRepository_AddingTwoStudentStudentWithSameCF_ThrowsExceptionInvalidOperation()
        {
            // arrange
            IStudentRepository repo = new InMemoryStudentRepository(new MockHashedGeneratedStudentIdGenerator());
            Student firstStudent = new Student() { LastName = "Pallo", Name = "Pinco", CF = "TestCF" };
            Student secondStudent = new Student() { LastName = "Caio", Name = "Tizio", CF = "TestCF" };
            repo.AddStudent(firstStudent);

            // act
            // assert
            Assert.Throws(typeof(InvalidOperationException), () => repo.AddStudent(secondStudent));

        }
    }
}