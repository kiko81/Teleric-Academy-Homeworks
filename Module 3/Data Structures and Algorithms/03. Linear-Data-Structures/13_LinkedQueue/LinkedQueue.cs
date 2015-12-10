// Implement the ADT queue as dynamic linked list.
// Use generics (LinkedQueue<T>) to allow storing different data types in the queue.

namespace LinkedQueue
{
    using LinkedList;

    public class LinkedQueue<T>
    {
        private LinkedList<T> linkedList;

        public LinkedQueue()
        {
            this.linkedList = new LinkedList<T>();
        }

        public int Length
        {
            get
            {
                return this.linkedList.Length;
            }
        }

        public void Enqueue(T value)
        {
            var itemToEnque = new ListItem<T>();
            itemToEnque.Value = value;

            this.linkedList.AddLast(itemToEnque);
        }

        public T Dequeue()
        {
            var returnValue = this.linkedList.FirstElement.Value;

            this.linkedList.RemoveFirst();
            return returnValue;
        }

        public T Peek()
        {
            return this.linkedList.FirstElement.Value;
        }
    }
}
