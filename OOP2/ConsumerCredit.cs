using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class ConsumerCredit : ICreditManager
    {
        public void calculate()
        {
            Console.WriteLine("Consumer Credit: Calculated");
        }

        public void result()
        {
            throw new NotImplementedException();
        }
    }
}
