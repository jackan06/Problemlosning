using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett namn:");
            string namn = Console.ReadLine();
            string nyttNamn = "";

            for (int i = 0; i < namn.Length-1; i++)
            {
                
                    if (namn[i] != namn[i + 1])
                    {
                        nyttNamn += namn[i];
                    }
            }
            nyttNamn += namn[namn.Length-1];
            Console.WriteLine(nyttNamn);
            Console.ReadKey();
        }
    }
}
