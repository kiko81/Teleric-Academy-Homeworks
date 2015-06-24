namespace BankAccounts
{
    public abstract class Account : IAccount
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        protected Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer
        {
            get { return this.customer; }
            private set { this.customer = value; }
        }

        public decimal Balance
        {
            get { return this.balance; }
            protected set { this.balance = value; }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            protected set { this.interestRate = value; }
        }

        public AccountType AccountType { get; protected set; }


        public virtual decimal CalculateInterest(int months)
        {
            return InterestRate * months;
        }

        public void Deposit(decimal sum)
        {
            this.Balance += sum;
        }
    }
}
