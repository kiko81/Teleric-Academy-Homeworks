namespace AdapterDemo
{
    public class AdapterDemo
    {
        static void Main()
        {
            Target target = new Target();
            target.Request();
            Target target2 = new Adapter();
            target2.Request();
        }
    }
}
