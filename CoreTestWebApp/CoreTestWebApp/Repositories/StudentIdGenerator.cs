using System;
using System.Linq;
using CoreTestWebApp.Models;

namespace CoreTestWebApp.Repositories
{
    public class StudentIdGenerator : IStudentIdGenerator
    {
        private readonly ITimeService _timeService;

        public StudentIdGenerator(ITimeService timeService)
        {
            _timeService = timeService;
        }

        public long GenerateIdForStudent(Student student)
        {
            char firstTwoLetterOfName = student.Name.First();
            char firstTowLetterOfLastName = student.LastName.First();
            var date = _timeService.GetCurrentDate();
            
            return Int64.Parse($"{((int)firstTowLetterOfLastName)}{((int)firstTwoLetterOfName)}{date:ddMMyy}");
        }
    }
}