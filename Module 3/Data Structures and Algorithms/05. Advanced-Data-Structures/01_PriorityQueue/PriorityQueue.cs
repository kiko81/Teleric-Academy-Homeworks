namespace PriorityQueue
{
    using System;
    using System.Collections.Generic;

    public class PriorityQueue<T> where T : IComparable<T>
    {
        private readonly bool isAscending;
        private List<T> items;

        public PriorityQueue(bool ascending = true)
        {
            this.items = new List<T>();
            this.isAscending = ascending;
        }

        public int Count
        {
            get { return this.items.Count; }
        }

        public void Enqueue(T child)
        {
            this.items.Add(child);
            if (this.items.Count > 0)
            {
                var parentIndex = this.items.Count / 2;
                var parent = this.items[parentIndex];
                var childIndex = this.items.Count - 1;

                this.Reorder(parent, child, parentIndex, childIndex);
            }
        }

        public T Dequeue()
        {
            if (this.items.Count == 0)
            {
                return default(T);
            }

            var result = this.items[0];

            var lastIndex = this.items.Count - 1;
            this.items[0] = this.items[lastIndex];
            this.items.RemoveAt(lastIndex);

            if (this.isAscending)
            {
                this.MinHeapify(0);
            }
            else
            {
                this.MaxHeapify(0);
            }

            return result;
        }

        public T Peek()
        {
            return this.items[0];
        }

        private void Reorder(T parent, T child, int parentIndex, int childIndex)
        {
            while (this.CompareAscending(parent, child))
            {
                this.items[parentIndex] = child;
                this.items[childIndex] = parent;

                if (parentIndex == 0)
                {
                    break;
                }

                child = this.items[parentIndex];
                childIndex = parentIndex;
                parentIndex = (parentIndex - 1) / 2;
                parent = this.items[parentIndex];
            }
        }

        private void MaxHeapify(int parentIndex)
        {
            while (true)
            {
                var left = (2 * parentIndex) + 1;
                var right = (2 * parentIndex) + 2;
                var max = parentIndex;
                if (left < this.items.Count && this.items[left].CompareTo(this.items[max]) > 0)
                {
                    max = left;
                }

                if (right < this.items.Count && this.items[right].CompareTo(this.items[max]) > 0)
                {
                    max = right;
                }

                if (max.CompareTo(parentIndex) != 0)
                {
                    T storedValue = this.items[max];
                    this.items[max] = this.items[parentIndex];
                    this.items[parentIndex] = storedValue;
                    parentIndex = max;
                    continue;
                }

                break;
            }
        }

        private void MinHeapify(int parentIndex)
        {
            while (true)
            {
                var left = (2 * parentIndex) + 1;
                var right = (2 * parentIndex) + 2;
                var min = parentIndex;
                if (left < this.items.Count && this.items[left].CompareTo(this.items[min]) < 0)
                {
                    min = left;
                }

                if (right < this.items.Count && this.items[right].CompareTo(this.items[min]) < 0)
                {
                    min = right;
                }

                if (min.CompareTo(parentIndex) != 0)
                {
                    T storedValue = this.items[min];
                    this.items[min] = this.items[parentIndex];
                    this.items[parentIndex] = storedValue;
                    parentIndex = min;
                    continue;
                }

                break;
            }
        }

        private bool CompareAscending(T parent, T child)
        {
            if (this.isAscending)
            {
                return parent.CompareTo(child) > 0;
            }

            return parent.CompareTo(child) < 0;
        }
    }
}