namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items => this.items;

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            return this.items.Any(value => item.CompareTo(value) == 0);
        }

        public bool BinarySearch(T item)
        {
            this.Sort(new Quicksorter<T>());
            var start = 0;
            var end = this.items.Count - 1;
            while (start <= end)
            {
                var middle = (end + start) / 2;
                if (this.items[middle].CompareTo(item) == 0)
                {
                    return true;
                }

                if (this.items[middle].CompareTo(item) < 0)
                {
                    start = middle + 1;
                }
                else
                {
                    end = middle - 1;
                }
            }

            return false;
        }

        public void Shuffle()
        {
            var random = new Random();
            for (var i = 0; i < this.items.Count - 2; i++)
            {
                var j = random.Next(i, this.items.Count);
                var buffer = this.items[i];
                this.items[i] = this.items[j];
                this.items[j] = buffer;
            }
        }

        public void Print()
        {
            for (var i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
