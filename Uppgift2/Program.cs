using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett nummer mellan 1 och 100:");
            int nummer = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nummer; i++)
            {
                Console.WriteLine(i+" Abracadabra");
            }

            Console.ReadKey();
        }
    }
}
