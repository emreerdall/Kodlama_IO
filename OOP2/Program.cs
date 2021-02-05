using System;
using System.Collections.Generic;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager consumerCredit = new ConsumerCredit();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager houseCreditManager = new HouseCreditManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            AppManager appManager = new AppManager();
            appManager.apply(consumerCredit, databaseLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>() {houseCreditManager, vehicleCreditManager };
            appManager.CreditPreInform(credits);

            Console.ReadKey();

             
        }
    }
}
