using System;
using System.Collections.Generic;
using System.Text;

namespace Jan16_Methods
{
    class SptManager
    {
        //naming convention
        public void Add(Productx product)
        {
            Console.WriteLine("Sepete Eklendi : " + product.Name);
        }

        //bad example
        public void AddAlternate(string productName, string description, double price)
        {
            Console.WriteLine("Sepete Eklendi : " + productName);
        }

	}
}
