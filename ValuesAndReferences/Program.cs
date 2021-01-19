using System;

namespace ValuesAndReferences
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 30;
            n1 = n2;
            n2 = 65;
            //n1 ? sorusu cevabı 30

            int[] numbers1 = new int[] { 10, 20, 30 };
            int[] numbers2 = new int[] { 100, 200, 300 };
            numbers1 = numbers2;
            numbers2[0] = 999;
            //numbers1[0] ? cevabı 999

            //ÇÜNKÜ --- value var'ın direk value'sunu değiştirirken, reference, tutulan kodun
            //referans kodunu değiştirir.

            //int, decimal, float, double, bool = value
            //array, class, interface = reference
        }
    }
}
