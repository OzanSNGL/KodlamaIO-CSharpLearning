using System;


namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> names = new MyDictionary<int, string>();
            names.Add(01, "Ozan");
            names.Add(02, "Defne");
            names.Add(03, "Şans");
            names.Add(04, "Hera");
            names.Add(05, "Umut");
            names.Add(06, "Tuncay");
            names.Add(07, "Benek");
            names.Add(08, "Rita");


            foreach (var a in names.Words )
            {
                Console.WriteLine(a);
            }

            foreach (var b in names.Keys)
            {
                Console.WriteLine(b);
            }

        }
    }
}
