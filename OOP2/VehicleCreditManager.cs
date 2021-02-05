using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class VehicleCreditManager : ICreditManager
    {
        public void calculate()
        {
            Console.WriteLine("Vehicle Credit: Calculated");
        }

        public void result()
        {
            throw new NotImplementedException();
        }
    }
}
