namespace DecoratorDemo
{
    public class DecoratorDemo
    {
        static void Main()
        {
            {
                ConcreteComponent c = new ConcreteComponent();
                ConcreteDecoratorA d1 = new ConcreteDecoratorA();
                ConcreteDecoratorB d2 = new ConcreteDecoratorB();

                d1.SetComponent(c);
                d2.SetComponent(d1);

                d2.Operation();
            }
        }
    }
}
