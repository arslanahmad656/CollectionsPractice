using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPractice.BoxCollectionExample
{
    public class BoxCollection : ICollection<Box>
    {
        private List<Box> _collection;

        public BoxCollection()
        {
            _collection = new List<Box>();
        }

        public Box this[int index]
        {
            get
            {
                return _collection[index];
            }
            set
            {
                _collection[index] = value;
            }
        }

        public int Count => _collection.Count;

        public bool IsReadOnly => false;

        public void Add(Box item)
        {
            _collection.Add(item);
        }

        public void Clear()
        {
            _collection.Clear();
        }

        public bool Contains(Box item)
        {
            foreach (Box box in _collection)
            {
                if (box.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(Box[] array, int arrayIndex)
        {
            throw new NotSupportedException("Copy operation is not availabe at the moment!");
        }

        public IEnumerator<Box> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(Box item)
        {
            foreach (var box in _collection)
            {
                if (item.Equals(box))
                {
                    return _collection.Remove(item);
                }
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
