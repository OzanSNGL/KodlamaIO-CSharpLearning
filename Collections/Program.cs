using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string> { "Ozan", "Umut", "Tuncay", "Defne" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[3]);
            isimler.Add("Ezgi");
            Console.WriteLine(isimler[4]);
        }
    }
}
