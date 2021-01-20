using System;

namespace PrimeFinder1
{
    class Program
    {
        static void Main(string[] args)
        {
            start: int num1;
                Console.WriteLine("Please enter a number:");
                num1 = Convert.ToInt32(Console.ReadLine());
                if (num1 == 0 | num1 == 1)
                {
                    Console.WriteLine(num1 + " is not a prime number.\n");
                    goto start;
                }
                else
                {
                    for (int i = 2; i <= num1 / 2; i++)
                    {
                        if (num1 % i == 0)
                        {
                            Console.WriteLine(num1 + " is not a prime number.\n");
                        }

                    }
                    Console.WriteLine(num1 + " is a prime number.\n");
                }
                goto start;
            }
        }
    }
