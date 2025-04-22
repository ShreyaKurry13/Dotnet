namespace Banking;

class SavingsAccount : Account , IProfitable 
{
    const decimal MinBal = 5000;

    internal SavingsAccount()
    {
        Balance  = MinBal;
    }

    public override void Deposit(decimal amount)
    {
        if(Balance >= 50000)
            amount -= 100;
        Balance += amount;
    }

    public sealed override void Withdraw(decimal amount)
    {
        if(Id < 0)
            throw new NotSupportedException("Account is locked");
        if(Balance - amount < MinBal)
            throw new InsufficientFundsException();
        Balance -= amount;
    }

    public decimal AddInterest(int months)
    {
        decimal rate = Balance < 5 * MinBal ? 3 : 4;
        decimal interest = Balance * months * rate /1200;
        Balance += interest;
        return interest;
    }
}