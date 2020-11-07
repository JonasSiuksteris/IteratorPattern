using System.Collections;
using System.Collections.Generic;

namespace IteratorPattern
{
    public class Collection : ICollection
    {
        private readonly ArrayList _items = new ArrayList();

        public object this[int index]
        {
            get => _items[index];
            set => _items.Add(value);
        }

        public Collection()
        {
            
        }

        public Collection(IEnumerable<object> objects)
        {
            foreach (var o in objects)
            {
                _items.Add(o);
            }
        }

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        public int Count()
        {
            return _items.Count;
        }

    }
}
