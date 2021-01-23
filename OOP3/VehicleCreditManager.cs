using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class VehicleCreditManager : ICreditBaseManager
    {
        public void Calculate()
        {
            Console.WriteLine("Your vehicle credit has been calculated.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
