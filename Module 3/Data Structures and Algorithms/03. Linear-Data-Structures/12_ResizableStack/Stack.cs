// Implement the ADT stack as auto-resizable array.
// Resize the capacity on demand (when no space is available to add / insert a new element).

namespace ResizableStack
{
    public class Stack<T>
    {
        private T[] stack;
        private int index;

        public Stack(int size = 16)
        {
            this.stack = new T[size];
            this.index = 0;
        }

        public int Count()
        {
            return this.index;
        }

        public T Peek()
        {
            if (this.Count() == 0)
            {
                return default(T);
            }

            return this.stack[this.index];
        }

        public T Pop()
        {
            if (this.Count() == 0)
            {
                return default(T);
            }

            var returnValue = this.stack[this.index - 1];

            if (this.index > 0)
            {
                this.index--;
            }

            return returnValue;
        }

        public void Push(T value)
        {
            this.UpdateSize();
            this.stack[this.index++] = value;
        }

        private void UpdateSize()
        {
            if (this.index == this.stack.Length)
            {
                var doubleStack = new T[this.stack.Length * 2];

                for (var i = 0; i < this.stack.Length; i++)
                {
                    doubleStack[i] = this.stack[i];
                }

                this.stack = doubleStack;
            }
        }
    }
}
