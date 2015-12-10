namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            for (var i = 0; i < collection.Count; i++)
            {
                var minElement = collection[i];
                var minElementPosition = i;

                for (var j = i + 1; j < collection.Count; j++)
                {
                    if (collection[j].CompareTo(minElement) < 0)
                    {
                        minElement = collection[j];
                        minElementPosition = j;
                    }
                }

                collection[minElementPosition] = collection[i];
                collection[i] = minElement;
            }
        }
    }
}
