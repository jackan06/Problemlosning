using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int antal = int.Parse(Console.ReadLine());
            int[] pris = new int[antal];
            int minstaPris = 0;
            int gratisBöcker = antal / 3;
            int borttagnaBöcker = 0;
            for (int i = 0; i < antal; i++)
            {
                pris[i] = int.Parse(Console.ReadLine());
            }

            //Sorterar fältet så det minsta talet kommer först
            Array.Sort(pris);
            //Sorterar fältet så det största talet kommer först
            Array.Reverse(pris);
            for (int j = 0; j < antal; j++)
            {
                minstaPris += pris[j];

            
                    if ((j+1) % 3 == 0 && borttagnaBöcker<gratisBöcker)
                    {
                        minstaPris -= pris[j];
                        borttagnaBöcker++;
                    }
            }

            Console.WriteLine(minstaPris.ToString());

            Console.ReadKey();
        }
    }
}
