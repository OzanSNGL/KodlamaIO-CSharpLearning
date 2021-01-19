using System;

namespace Jan16_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Productx product1 = new Productx();
            product1.Name = "Elma";
            product1.Price = 12;
            product1.Description = "Amasya Elması";

            Productx product2 = new Productx();
            product2.Name = "Karpuz";
            product2.Price = 45;
            product2.Description = "Diyarbakır Karpuzu";

            Productx[] products = new Productx[] { product1, product2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price + " TL");
                Console.WriteLine(product.Description);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("************Methods************");

            //instance
            SptManager sepetManager = new SptManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.AddAlternate("Armut", "Yeşil Armut", 12);
        }
    }
}
