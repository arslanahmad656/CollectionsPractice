using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPractice.InfiniteEnumerable
{
    public class RandomNumberGenerator : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator() => new InfiniteEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
