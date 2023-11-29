using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hur många stenar finns det: ");
            int stenar = int.Parse(Console.ReadLine());

            if (stenar%2 == 0)
            {
                Console.WriteLine("Bob");
            }

            else
            {
                Console.WriteLine("Alice");
            }

            Console.ReadKey(); 
        }
    }
}
