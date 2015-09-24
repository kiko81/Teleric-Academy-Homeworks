namespace Strategy
{
    public class Context
    {
        private Strategy strategy;

        // Constructor
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }
    }
}
