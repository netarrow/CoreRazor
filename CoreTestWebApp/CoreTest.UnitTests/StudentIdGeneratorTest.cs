using System;
using System.Collections.Generic;
using System.Text;
using CoreTest.UnitTests.Mocks;
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
        public void StudentIdGenerator_GeneredId_Student_StartWith_T_and_P_MustStartWithStudentInitials()
        {
            StudentIdGenerator generator = new StudentIdGenerator(new MockPrefetchedTimeService(new DateTime(2020, 1, 10)));
            var student = new Student() { LastName = "Prova", Name = "Test" };

            long studentId = generator.GenerateIdForStudent(student);
            var studentIdStr = studentId.ToString();

            Assert.That(() => studentIdStr.StartsWith("8084"), () => studentIdStr);
        }

        [Test]
        public void StudentIdGenerator_GeneredId_Student_StartWith_A_and_E_MustStartWithStudentInitials()
        {
            StudentIdGenerator generator = new StudentIdGenerator(new MockPrefetchedTimeService(new DateTime(2020, 1, 10)));
            var student = new Student() { LastName = "Experiment", Name = "Another" };

            long studentId = generator.GenerateIdForStudent(student);
            var studentIdStr = studentId.ToString();

            Assert.That(() => studentIdStr.StartsWith("6965"), () => studentIdStr);
        }

        [Test]
        public void StudentIdGenerator_GeneredId_Student_CreatedOn_10_January_2020_MustEndsWith100120()
        {
            StudentIdGenerator generator = 
                new StudentIdGenerator(new MockPrefetchedTimeService(new DateTime(2020, 1, 10)));
            var student = new Student() { LastName = "Experiment", Name = "Another" };

            long studentId = generator.GenerateIdForStudent(student);
            var studentIdStr = studentId.ToString();

            Assert.AreEqual("6965100120", studentIdStr);
        }

    }
}
