namespace BankAccounts
{
    class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
            this.AccountType = AccountType.Mortgage;
        }

        public override decimal CalculateInterest(int months)
        {
            decimal interest = 0;
            if (this.Customer == Customer.Individual)
            {
                interest = base.CalculateInterest(months) - InterestRate * 6;
            }
            else if (this.Customer == Customer.Company)
            {
                if (months <= 12)
                {
                    interest = base.CalculateInterest(months)/2;
                }
                else
                {
                    interest = base.CalculateInterest(months - 6);
                }
            }

            if (interest <= 0)
            {
                return 0;
            }

            return interest;
        }
    }
}
