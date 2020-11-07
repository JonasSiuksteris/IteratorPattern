namespace IteratorPattern
{
    public class Iterator : IIterator
    {
        private readonly Collection _collection;
        private int _current;
        private const int Step = 1;

        public Iterator(Collection collection)
        {
            _collection = collection;
        }
        public object First()
        {
            _current = 0;
            return _collection[_current];
        }

        public object Next()
        {
            _current += Step;
            return !IsDone() ? _collection[_current] : null;
        }

        public bool IsDone()
        {
            return _current >= _collection.Count();
        }

        public object CurrentItem()
        {
            return _collection[_current];
        }
    }
}
