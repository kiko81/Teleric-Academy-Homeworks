namespace Memento
{
    public class MementoDemo
    {
        static void Main()
        {
            Originator originator = new Originator();
            originator.State = "On";

            // Store internal state
            Caretaker c = new Caretaker();
            c.Memento = originator.CreateMemento();

            // Continue changing originator
            originator.State = "Off";

            // Restore saved state
            originator.SetMemento(c.Memento);
        }
    }
}
