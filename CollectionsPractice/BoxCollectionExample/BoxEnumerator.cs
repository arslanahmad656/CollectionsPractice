using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPractice.BoxCollectionExample
{
    public class BoxEnumerator : IEnumerator<Box>
    {
        private Box _currentBox;
        private int _currentIndex;
        private BoxCollection _collection;

        public BoxEnumerator(BoxCollection collection)
        {
            _currentIndex = -1;
            _currentBox = null;
            _collection = collection;
        }

        public Box Current => _currentBox;

        object IEnumerator.Current => _currentBox;

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            if (_currentIndex >= _collection.Count)
            {
                return false;
            }
            _currentIndex++;
            _currentBox = _collection[_currentIndex];
            return true;
        }

        public void Reset()
        {
            _currentIndex = -1;
        }
    }
}
