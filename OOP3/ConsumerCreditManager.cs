using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ConsumerCreditManager : ICreditBaseManager
    {
        public void Calculate()
        {
            Console.WriteLine("Your consumer credit has been calculated.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
