// Implement the data structure set in a class HashedSet<T> using your class HashTable<K, T> to hold the // elements.Implement all standard set operations like
// 
// * Add(T)
// * Find(T)
// * Remove(T)
// * Count
// * Clear()
// * union and
// * intersect

namespace Implementations
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class HashedSet<T> : IEnumerable<T>
    {
        private HashTable<int, T> values;
        private int count;

        public HashedSet()
        {
            this.Clear();
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public void Clear()
        {
            this.count = 0;
            this.values = new HashTable<int, T>();
        }

        public void Add(T value)
        {
            var key = this.GetHashCode(value);
            this.values.Add(key, value);
            this.count++;
        }

        public T Find(T value)
        {
            var key = this.GetHashCode(value);
            return this.values[key];
        }

        public void Remove(T value)
        {
            var key = this.GetHashCode(value);
            this.values.Remove(key);
            this.count--;
        }

        public HashedSet<T> Intersect(HashedSet<T> other)
        {
            var result = new HashedSet<T>();

            foreach (var item in from item in this.values
                                 from otherItem in other.values
                                 where item.Key == otherItem.Key
                                 select item)
            {
                result.Add(item.Value);
            }

            return result;
        }

        public HashedSet<T> Union(HashedSet<T> other)
        {
            var result = new HashedSet<T>();

            foreach (var item in this.values)
            {
                result.Add(item.Value);
            }

            foreach (var item in other.values.Where(item => !result.values.Contains(item.Key)))
            {
                result.Add(item.Value);
            }

            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.values.Select(item => item.Value).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            return string.Join(", ", this);
        }

        private int GetHashCode(T value)
        {
            var hash = value.GetHashCode();

            if (hash < 0)
            {
                hash *= -1;
            }

            return hash;
        }
    }
}