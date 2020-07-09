using System;
using CoreTestWebApp.Repositories;

namespace CoreTest.UnitTests.Mocks
{
    public class MockPrefetchedTimeService : ITimeService
    {
        private readonly DateTime _dateTime;

        public MockPrefetchedTimeService(DateTime dateTime)
        {
            _dateTime = dateTime;
        }
        public DateTime GetCurrentDate()
        {
            return _dateTime;
        }
    }
}