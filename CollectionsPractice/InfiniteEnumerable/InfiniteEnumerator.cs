using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPractice.InfiniteEnumerable
{
    public class InfiniteEnumerator : IEnumerator<int>
    {
        private Random _generator;

        public InfiniteEnumerator()
        {
            _generator = new Random();
        }

        public int Current => _generator.Next();

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            
        }

        public bool MoveNext() => true;

        public void Reset()
        {
            
        }
    }
}
