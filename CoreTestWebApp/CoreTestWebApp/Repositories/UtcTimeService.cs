using System;

namespace CoreTestWebApp.Repositories
{
    public class UtcTimeService : ITimeService
    {
        public UtcTimeService()
        {
        }

        public DateTime GetCurrentDate()
        {
            return DateTime.UtcNow;
        }
    }
}   