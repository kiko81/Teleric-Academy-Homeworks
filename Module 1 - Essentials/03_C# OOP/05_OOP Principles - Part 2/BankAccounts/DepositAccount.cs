namespace BankAccounts
{
    using System;

    public class DepositAccount : Account, IWithdraw
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
            this.AccountType = AccountType.Deposit;
        }

        public void Withdraw(decimal sum)
        {
            if (sum > this.Balance)
            {
                throw new ArgumentOutOfRangeException("Insufficient funds, please choose smaller amount to withdraw. Your balance: " + this.Balance);
            }
            this.Balance -= sum;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }

            return base.CalculateInterest(months);
        }
    }
}
