using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1000001;
            customer1.Name = "John";
            customer1.Surname = "Foley";
            customer1.Working = true;

            Customer customer2 = new Customer();
            customer2.Id = 1000002;
            customer2.Name = "Lacy";
            customer2.Surname = "Evans";
            customer2.Working = false;

            Customer customer3 = new Customer();
            customer3.Id = 1000003;
            customer3.Name = "Victor";
            customer3.Surname = "Oladipo";
            customer3.Working = true;

            Customer customer4 = new Customer();
            customer4.Id = 1000004;
            customer4.Name = "Blake";
            customer4.Surname = "Mannings";
            customer4.Working = false;

            Customer[] allCustomers = new Customer[] { customer1, customer2, customer3, customer4 };

            CustomerManager customerManager = new CustomerManager();



            foreach (var x in allCustomers)
            {
                customerManager.Add(x);
                Console.WriteLine("--------");
            }

            Console.WriteLine("Non-Retired Customers: \n__________");

            for (int j = 0; j < allCustomers.Length; j++)
            {
                if (allCustomers[j].Working == true)
                {
                    customerManager.ListAll(allCustomers[j]);
                    Console.WriteLine("*****");

                }
            }


            Console.WriteLine(" ");

            start: Console.WriteLine("Please enter an ID Code:");

            int Number = new int();
            Number = Convert.ToInt32(Console.ReadLine());

            bool foundIt = new bool();

            for (int i = 0; i < allCustomers.Length; i++)
            {
                if (Number == allCustomers[i].Id)
                {
                    foundIt = true;
                    customerManager.Delete(allCustomers[i]);
                    goto start;
                }
                foundIt = false;

            }
            if (foundIt == false)
            {
                Console.WriteLine("You have entered an invalid ID Code.");
                goto start;
            }






        }
    }
}
