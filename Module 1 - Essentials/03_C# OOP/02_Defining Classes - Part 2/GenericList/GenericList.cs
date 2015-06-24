namespace GenericList
{
    using System;
    using System.Text;
    using System.Linq;
    using System.Collections.Generic;

    public class GenericList<T> where T : IComparable
    {
        private T[] list;
        private int nextIndex = 0;

        public GenericList(int size)
        {
            this.list = new T[size];
        }

        public T this[int index]
        {
            get { return this.list[index]; }
            private set { this.list[index] = value; }
        }

        public void Add(T element)
        {
            this.list[nextIndex] = element;
            this.nextIndex++;
        }

        public void Clear()
        {
            this.list = new T[this.list.Length];
        }

        public void Remove(int index)
        {
            for (int i = index; i < this.nextIndex; i++)
            {
                this.list[i] = this.list[i + 1];
            }

            this.nextIndex--;
        }

        public void Insert(int index, T element)
        {
            if (this.nextIndex == this.list.Length)
            {
                this.AutoGrow();
            }

            for (int i = this.nextIndex; i >= index && i > 0; i--)
            {
                this.list[i] = this.list[i - 1];
            }

            this.list[index] = element;
            this.nextIndex++;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.nextIndex; i++)
            {
                sb.Append(this.list[i]);
                if (i != nextIndex - 1)
                {
                    sb.Append(',');
                }
            }

            return sb.ToString();
        }

        private void AutoGrow()
        {
            var newList = new T[this.list.Length * 2];

            for (int i = 0; i < this.list.Length; i++)
            {
                newList[i] = this.list[i];
            }
        }     

        public T Min()
        {
            T min = this.list[0];

            foreach (T item in this.list)
            {
                if (min.CompareTo(item) > 0)
                {
                    min = item;
                }
            }
            return min;
        }

        public T Max()
        {
            {
                T max = this.list[0];

                foreach (T item in this.list)
                {
                    if (max.CompareTo(item) < 0)
                    {
                        max = item;
                    }
                }
                return max;
            }
        }

        public int ElementByValue(T element)
        {
            int result = 0;
            for (int i = 0; i < this.list.Length; i++)
            {
                if (this.list[i].CompareTo(element) == 0)
                {
                    result = i;
                }
            }
            return result;
        }
    }
}
