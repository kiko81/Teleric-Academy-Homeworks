namespace BankAccounts
{
    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
            this.AccountType = AccountType.Loan;
        }

        public override decimal CalculateInterest(int months)
        {
            decimal interest = 0;
            if (this.Customer == Customer.Individual)
            {
                interest = base.CalculateInterest(months) - InterestRate * 3;
            }
            else if (this.Customer == Customer.Company)
            {
                interest = base.CalculateInterest(months) - InterestRate * 2;
            }
            if (interest <= 0)
            {
                return 0;
            }
            
            return interest;
        }
    }
}
