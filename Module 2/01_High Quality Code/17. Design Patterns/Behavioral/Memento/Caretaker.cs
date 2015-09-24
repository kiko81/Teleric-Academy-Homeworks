namespace Memento
{
    public class Caretaker
    {
        private Memento memento;

        // Gets or sets memento
        public Memento Memento
        {
            set { memento = value; }
            get { return memento; }
        }
    }
}
