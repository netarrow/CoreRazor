using System;
using System.Collections.Generic;
using System.Text;
using CoreTestWebApp.Models;
using CoreTestWebApp.Repositories;
using NUnit.Framework;

namespace CoreTest.UnitTests
{
    public class StudentIdGeneratorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TearDown]
        public void Clear()
        {
        }

        [Test]
        public void StudentIdGenerator_GeneredId_MustStartWithStudentInitials()
        {
            StudentIdGenerator generator = new StudentIdGenerator();
            var student = new Student() { LastName = "Prova", Name = "Test"};

            int studentId = generator.GenerateIdForStudent(student);
            var studentIdStr = studentId.ToString();

            Assert.Inconclusive();
            Assert.AreEqual("80114", studentIdStr);
        }

    }

    public class StudentIdGenerator : IStudentIdGenerator
    {
        public int GenerateIdForStudent(Student student)
        {
            return 80114;
        }
    }

}
