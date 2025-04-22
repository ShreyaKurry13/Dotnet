using Banking;

namespace Banking;

sealed class CurrentAccount : Account
{
    public override void Deposit(decimal amount)
    {
        if(Balance < 0)
            amount -=500;
        Balance += amount;
    }

    public override void Withdraw(decimal amount)
    {
        if(Id < 0)
            throw new NotSupportedException("Account is Locked");
        Balance -= amount;
    }
}