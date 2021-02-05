using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class AppManager
    {
        public void apply(ICreditManager creditManager, ILoggerService loggerService)
        {
            creditManager.calculate();
            loggerService.Log();
        }
        public void CreditPreInform(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.calculate();
            }
        }
    }
}
