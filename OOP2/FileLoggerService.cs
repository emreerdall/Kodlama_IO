using System;

namespace OOP2
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Logged on File");
        }
    }
}
