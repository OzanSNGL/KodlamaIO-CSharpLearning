using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("New Customer Added. : " + customer.Name + " " + customer.Surname);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer Deleted. : " + customer.Name + " " + customer.Surname);
        }

        public void ListAll(Customer customer)
        {
            Console.WriteLine(customer.Id + "\r\n" + customer.Name + "\r\n" + customer.Surname);
        }

        public void ListWorking(Customer customer)
        {
            Console.WriteLine(customer.Id + "\r\n" + customer.Name + "\r\n" + customer.Surname);
        }
        
            
    }
}
