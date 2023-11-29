using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ditt första tal och medelvärdet med ett mellanslag mellan");
            string tal= Console.ReadLine();
            string[] uppdelat = tal.Split(' ');
            int tal1 = int.Parse(uppdelat[0]);
            int medelvärde = int.Parse(uppdelat[1]);
            int tal2 = (medelvärde * 2) - tal1;

            Console.WriteLine(tal2);

            Console.ReadKey();
        }
    }
}
