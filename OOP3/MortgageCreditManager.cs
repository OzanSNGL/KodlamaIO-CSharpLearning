using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortgageCreditManager : ICreditBaseManager
    {
        public void Calculate()
        {
            Console.WriteLine("Your mortgage has been calculated.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
