using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPractice
{
    class DiverExemples
    {
        public static void Début()
        {
            DemoInfiniteRandomNumbers();
        }

        static void DemoInfiniteRandomNumbers()
        {
            Console.WriteLine("Some random numbers:");
            int count = 20;
            foreach (var num in new InfiniteEnumerable.RandomNumberGenerator())
            {
                if (count-- <= 0)
                {
                    break;
                }
                Console.Write($"{num}  ");
            }
        }
    }
}
