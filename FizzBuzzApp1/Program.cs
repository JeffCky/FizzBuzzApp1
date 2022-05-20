using System;
using System.Collections.Generic;

namespace FizzBuzzApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> iList = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                iList.Add(i);
            }
            foreach (int i in iList)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} is even.");
                    if ((i % 2 == 0) && (i % 5 == 0))
                    {
                        Console.WriteLine($"{i} is Divisble by 2 and 5.");
                    }
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i} is Divisible by 5.");
                }
            }
            Console.ReadLine();
        }
    }
}
