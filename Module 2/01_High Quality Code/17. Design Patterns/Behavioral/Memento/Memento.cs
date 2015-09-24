namespace Memento
{
    public class Memento
    {
        private string state;

        // Constructor
        public Memento(string state)
        {
            this.state = state;
        }

        // Gets or sets state
        public string State
        {
            get { return state; }
        }
    }
}
