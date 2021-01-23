using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        //method injection - dependency injection
        public void Apply(ICreditBaseManager creditBaseManager, ILoggerService loggerService)
        {
            creditBaseManager.Calculate();
            loggerService.Log();
        }

        public void CreditInfo(List<ICreditBaseManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
