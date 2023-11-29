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
            int[] pris = new int [antal];
            int minstaPris = 0;
            int gratisBöcker = antal / 3;
            for (int i = 0; i < antal; i++) 
            {
                pris[i] = int.Parse(Console.ReadLine());
            }
            
            Array.Sort(pris);

            for (int j=(gratisBöcker);j<antal; j++)
            {
                minstaPris += pris[j];
            }

            Console.WriteLine(minstaPris.ToString());
            Console.ReadKey();  
        }
    }
}
