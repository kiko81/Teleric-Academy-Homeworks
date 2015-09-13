namespace SimpleFactoryDemo
{
    public class CheckFactory
    {
        public CheckBook ChooseExpense(int input)
        {
            switch (input)
            {
                case 1:
                    return new Personal();
                case 2:
                    return new Travel();
                default:
                    return new Health();
            }
        }
    }
}
