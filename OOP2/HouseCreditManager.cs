using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class HouseCreditManager : ICreditManager
    {
        public void calculate()
        {
            Console.WriteLine("House Credit: Calculated");
        }

        public void result()
        {
            throw new NotImplementedException();
        }
    }
}
