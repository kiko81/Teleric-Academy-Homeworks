namespace TemplateMethod
{
    public class TemplateMethodDemo
    {
        static void Main()
        {
            AbstractClass c = new ConcreteClassA();
            c.TemplateMethod();

            c = new ConcreteClassB();
            c.TemplateMethod();
        }
    }
}
