// Implement the data structure hash table in a class HashTable<K, T>. Keep the data in array of lists of  key-//value pairs(LinkedList<KeyValuePair<K, T>>[]) with initial capacity of 16. When the hash table load  runs //over 75%, perform resizing to 2 times larger capacity.Implement the following methods and properties:
// 
// * Add(key, value)
// * Find(key)->value
// * Remove(key)
// * Count
// * Clear()
// * this[]
// * Keys
// Try to make the hash table to support iterating over its elements with foreach.

namespace Implementations
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class HashTable<K, T> : IEnumerable<KeyValuePair<K, T>>
    {
        private const float ResizeCoeff = 0.75f;

        private LinkedList<KeyValuePair<K, T>>[] values;
        private int count;
        private int capacity;

        public HashTable()
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

        public K[] Keys
        {
            get
            {
                var listOfKeys = new List<K>(this.count);
                listOfKeys.AddRange(this.Select(pair => pair.Key));

                return listOfKeys.ToArray();
            }
        }

        public T this[K key]
        {
            get
            {
                return this.FindValue(key);
            }
        }

        public void Clear()
        {
            this.count = 0;
            this.capacity = 16;
            this.values = new LinkedList<KeyValuePair<K, T>>[16];
        }

        public void Add(K key, T value)
        {
            if (this.Contains(key))
            {
                return;
            }

            var index = this.GetIndex(key);

            if (this.values[index] == null)
            {
                this.values[index] = new LinkedList<KeyValuePair<K, T>>();
            }

            this.values[index].AddFirst(new KeyValuePair<K, T>(key, value));
            ++this.count;

            if (this.count > ResizeCoeff * this.capacity)
            {
                this.ResizeAndRewritte();
            }
        }

        public T FindValue(K key)
        {
            var index = this.GetIndex(key);

            if (this.values[index] == null)
            {
                return default(T);
            }

            var chain = this.values[index];

            foreach (var pair in chain.Where(pair => pair.Key.Equals(key)))
            {
                return pair.Value;
            }

            return default(T);
        }

        public bool Contains(K key)
        {
            var index = this.GetIndex(key);

            if (this.values[index] == null)
            {
                return false;
            }

            var chain = this.values[index];

            return chain.Any(pair => pair.Key.Equals(key));
        }

        public void Remove(K key)
        {
            if (!this.Contains(key))
            {
                throw new InvalidOperationException("can not find key");
            }

            var index = this.GetIndex(key);

            var valueToRemove = this.values[index].First(item => item.Key.ToString() == key.ToString());
            this.values[index].Remove(valueToRemove);
            --this.count;

            if (this.values[index].Count == 0)
            {
                this.values[index] = null;
            }
        }

        public IEnumerator<KeyValuePair<K, T>> GetEnumerator()
        {
            return this.values.Where(valuesList => valuesList != null).SelectMany(valuesList => valuesList).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private int GetIndex(K key)
        {
            var hash = key.GetHashCode();

            if (hash < 0)
            {
                hash *= -1;
            }

            var index = hash % this.values.Length;

            return index;
        }

        private void ResizeAndRewritte()
        {
            var oldvalues = (LinkedList<KeyValuePair<K, T>>[])this.values.Clone();
            this.capacity *= 2;
            this.values = new LinkedList<KeyValuePair<K, T>>[this.capacity];
            this.count = 0;

            foreach (var value in oldvalues.Where(item => item != null).SelectMany(item => item))
            {
                this.Add(value.Key, value.Value);
            }
        }
    }
}