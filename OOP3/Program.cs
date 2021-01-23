using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            MortgageCreditManager mortgageCreditManager = new MortgageCreditManager();
            //interface can also be used
            ICreditBaseManager consumerCreditManager = new ConsumerCreditManager();
            VehicleCreditManager vehicleCreditManager = new VehicleCreditManager();
            ApplicationManager applicationManager = new ApplicationManager();


            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            //ne yazarsan o ---------------------------------- burası new DatabaseLoggerService() de olabilir
            applicationManager.Apply(vehicleCreditManager, databaseLoggerService);

            List<ICreditBaseManager> credits = new List<ICreditBaseManager>() {consumerCreditManager, vehicleCreditManager, mortgageCreditManager };

            //applicationManager.CreditInfo(credits);

        }
    }
}
