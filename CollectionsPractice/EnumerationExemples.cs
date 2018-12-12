using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPractice
{
    class EnumerationExemples
    {
        public static void Début()
        {
            //DemoInfiniteRandomNumbers();
            //SimulatingForeach();
            //DefiningIEnumerator2();
            DefiningIEnumerator3();
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

        static void SimulatingForeach()
        {
            var enumerable = new List<string>() { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5" };
            
            // IEnumerator<T> implements IDisposable
            using (var enumerator = enumerable.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    Console.WriteLine($"Current item: {enumerator.Current}");
                }
            }
        }

        static void DefiningIEnumerator1()
        {
            // see how the IEnumerator is implemented in the box collection demo
        }

        static void DefiningIEnumerator2()
        {
            foreach (var item in new MyList())
            {
                Console.Write($"{item}  ");
            }
        }

        static void DefiningIEnumerator3()
        {
            foreach (var item in GetInts())
            {
                Console.Write($"{item}  ");
            }
        }

        private static IEnumerable<int> GetInts()
        {
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
            yield return 5;
        }

        private class MyList : IEnumerable<int>
        {
            private int[] _innerCollection = new int[] { 1, 2, 3, 4, 5 };

            public IEnumerator<int> GetEnumerator()
            {
                foreach (var item in _innerCollection)
                {
                    yield return item;
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}
