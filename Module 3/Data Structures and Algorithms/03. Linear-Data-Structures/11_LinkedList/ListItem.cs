// Define a class ListItem<T> that has two fields: value(of type T) and NextItem(of type ListItem<T>).

namespace LinkedList
{
    public class ListItem<T>
    {
        public T Value { get; set; }

        public ListItem<T> NextItem { get; set; }
    }
}
