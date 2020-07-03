using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace CoreTest.UnitTests
{
    public class LearningTest
    {
        [Test]
        public void Test_Char_Integer_Value()
        {
            char p = 'P';
            char r = 'r';

            Console.WriteLine((int) p);
            Console.WriteLine((int) r);
        }
    }
}
