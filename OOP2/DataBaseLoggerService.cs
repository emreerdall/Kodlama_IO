using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class DataBaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Logged on database");
        }
    }
}
