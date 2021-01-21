using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region customers
            Customer customer1 = new Customer(1000001, "John", "Foley", true);

            Customer customer2 = new Customer(1000002, "Lacy", "Evans", false);

            Customer customer3 = new Customer(1000003, "Victor", "Oladipo", true);

            Customer customer4 = new Customer(1000004, "Blake", "Manning", false);

            Customer[] allCustomers = new Customer[] { customer1, customer2, customer3, customer4 };
            #endregion

            CustomerManager customerManager = new CustomerManager();

            #region yaz-customers
            foreach (var x in allCustomers)
            {
                customerManager.Add(x);
                Console.WriteLine("--------");
            }

            Console.WriteLine("Non-Retired Customers: \n__");

            for (int j = 0; j < allCustomers.Length; j++)
            {
                if (allCustomers[j].Working == true)
                {
                    customerManager.ListAll(allCustomers[j]);
                    Console.WriteLine("*");

                }
            }
            #endregion


        start: Console.WriteLine("Please choose one of the following: \r\n 1. Update a customer \r\n 2. Delete a customer");
            string o1 = null;
            o1 = Console.ReadLine();

            switch (o1)
            {
                #region case 1
                case "1":
                    Console.WriteLine("Please enter an ID Code: ");
                    int enteredNumber = new int();
                    enteredNumber = int.Parse(Console.ReadLine());
                    for (int a = 0; a < allCustomers.Length; a++)
                    {
                        if (enteredNumber == allCustomers[a].Id)
                        {
                            Console.WriteLine("Found : {0} {1}", allCustomers[a].Name, allCustomers[a].Surname);
                            Console.WriteLine("Please enter a new name: ");
                            allCustomers[a].Name = Console.ReadLine().ToString();
                            Console.WriteLine("You have successfully changed name.");
                            goto start;
                        }
                    }
                    Console.WriteLine("Couldn't find the ID you have entered : {0}", enteredNumber);
                    goto start;
                #endregion
                #region case 2
                case "2":
                    Console.WriteLine("Please enter an ID Code: ");
                    int enteredNumber2 = new int();
                    enteredNumber2 = int.Parse(Console.ReadLine());
                    for (int i = 0; i < allCustomers.Length; i++)
                    {
                        if (enteredNumber2 == allCustomers[i].Id)
                        {
                        yesorno: Console.WriteLine("Are you sure to delete " + allCustomers[i].Name + " " + allCustomers[i].Surname + "?" + "Y/N");
                            string yes = "Y";
                            string no = "N";
                            string o2 = null;
                            o2 = Console.ReadLine();
                            if (o2 == yes || o2 == no)
                            {
                                switch (o2)
                                {
                                    case "Y":
                                        customerManager.Delete(allCustomers[i]);
                                        goto start;
                                    case "N":
                                        Console.WriteLine(allCustomers[i].Name + allCustomers[i].Surname + "will not be deleted.");
                                        goto start;
                                }
                            }
                            Console.WriteLine("Please use either Y or N.");
                            goto yesorno;
                        }

                    }
                    Console.WriteLine("You have entered an invalid ID code.");
                    goto start;
                    #endregion
            }

        }
        }
    }

