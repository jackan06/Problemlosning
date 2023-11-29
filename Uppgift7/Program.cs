using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Första raden är vad han kan säga, andra raden är vad doktorn vill höra");
            string kanSäga = Console.ReadLine();
            string doktorVill = Console.ReadLine();
            int antalAKan = 0;
            int antalAVill = 0;
            for (int i = 0; i < kanSäga.Length; i++)
            {
                if (kanSäga[i] == 'a')
                {
                    antalAKan++;
                }
            }

            for (int i = 0; i < doktorVill.Length; i++)
            {
                if (doktorVill[i] == 'a')
                {
                    antalAVill++;
                }
            }

            if (antalAKan < antalAVill)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("go");
            }

            Console.ReadKey();
        }
    }
}
