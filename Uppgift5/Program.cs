using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv tre heltal på en rad med mellanslag mellan, sista talet vad datorn ska räkna till");
            string tal = Console.ReadLine();
            string[] split = tal.Split(' ');
            int x = int.Parse(split[0]);
            int y = int.Parse(split[1]);
            int n = int.Parse(split[2]);

            for (int i = 1; i <= n; i++)
            {
                if (i % x == 0 && i % y == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % y == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % x == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i.ToString());
                }
            }
            Console.ReadKey();
        }
    }
}
