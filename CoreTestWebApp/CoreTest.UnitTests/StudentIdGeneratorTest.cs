using System;
using System.Collections.Generic;
using System.Linq;
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
        public void StudentIdGenerator_GeneredId_Student_StartWith_T_and_P_MustStartWithStudentInitials()   
        {
            StudentIdGenerator generator = new StudentIdGenerator();
            var student = new Student() { LastName = "Prova", Name = "Test"};

            int studentId = generator.GenerateIdForStudent(student);
            var studentIdStr = studentId.ToString();

            Assert.AreEqual("8084", studentIdStr);
        }
        
        [Test]
        public void StudentIdGenerator_GeneredId_Student_StartWith_A_and_E_MustStartWithStudentInitials()
        {
            StudentIdGenerator generator = new StudentIdGenerator();
            var student = new Student() { LastName = "Experiment", Name = "Another"};   

            int studentId = generator.GenerateIdForStudent(student);
            var studentIdStr = studentId.ToString();

            Assert.AreEqual("6965", studentIdStr);
        }

    }

    public class StudentIdGenerator : IStudentIdGenerator
    {
        public int GenerateIdForStudent(Student student)
        {
            char firstTwoLetterOfName = student.Name.First();
            char firstTowLetterOfLastName = student.LastName.First();

            return Int32.Parse($"{((int)firstTowLetterOfLastName)}{((int)firstTwoLetterOfName)}");
        }
    }

}
