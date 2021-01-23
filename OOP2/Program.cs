using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.Name = "Ozan";
            customer1.Surname = "Şengül";
            customer1.TCNo = "12345678910";

            //cannot use Customer class
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "12346";
            customer2.CompanyName = "Pluto Has Eyes";
            customer2.TaxNo = "1234567890";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer2);
        }
    }
}
