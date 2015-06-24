namespace BankAccounts
{
    interface IAccount
    {
        Customer Customer { get; }

        decimal Balance { get; }

        decimal InterestRate { get; }

        decimal CalculateInterest(int months);

        void Deposit(decimal sum);
    }
}
