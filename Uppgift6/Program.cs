using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening där mellanslag är _");
            string mening= Console.ReadLine();
            int antalMellanslag = 0;
            int antalSmåBokstäver = 0;
            int antalStoraBokstäver = 0;
            int antalSymboler = 0;

            for (int i = 0; i < mening.Length; i++)
            {
                if (mening[i] == '_')
                {
                    antalMellanslag++;
                }
                else if (mening[i] >= 'a' && mening[i] <= 'z')
                {
                    antalSmåBokstäver++;
                }
                else if (mening[i] >= 'A' && mening[i] <= 'Z')
                {
                    antalStoraBokstäver++;
                }
                else if ((mening[i] >= '{' && mening[i] <='~') || (mening[i]>='!' && mening[i] <= '/')){
                    antalSymboler++;
                }
            }

            Console.WriteLine((double)antalMellanslag / mening.Length);
            Console.WriteLine((double)antalSmåBokstäver / mening.Length);
            Console.WriteLine((double)antalStoraBokstäver / mening.Length);
            Console.WriteLine((double)antalSymboler / mening.Length);

            Console.ReadKey(); 
        }
    }
}
