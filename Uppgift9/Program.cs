using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bråk = Console.ReadLine();
            string[] uppdelat = bråk.Split('/');
            int täljare = int.Parse(uppdelat[0]);
            int nämnare = int.Parse(uppdelat[1]);

            täljare -= (32 * nämnare);
            täljare *= 5;
            if (täljare % 9 == 0)
            {
                täljare /= 9;

            }
            else if (täljare % 3 == 0)
            {
                täljare /= 3;
                nämnare *= 3;
            }
            else
            {
                nämnare *= 9;
            }


            if (täljare % nämnare == 0)
            {
                Console.WriteLine((täljare / nämnare) + "/" + "1");
            }
            else
            {
                Console.WriteLine(täljare + "/" + nämnare);
            }
            

            Console.ReadKey();
        }
    }
}
