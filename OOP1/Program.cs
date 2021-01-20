using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product { Id = 1, CategoryId = 101, ProductName ="Masa", UnitInStock = 500, UnitPrice = 300 };
            Product product2 = new Product {Id = 2, CategoryId = 201, ProductName="Sandalye", UnitInStock= 430, UnitPrice = 250 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

        }
    }
}
