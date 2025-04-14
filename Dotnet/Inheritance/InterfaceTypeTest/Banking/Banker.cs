namespace Banking;

public static class Banker
{
    private static long seed = DateTime.Now.Ticks % 100000000;

    public static Account OpenCurrentAccount()
    {
        var acc = new CurrentAccount();
        acc.Id = ++seed + 100000000;
        return acc;
    }

    public static Account OpenSavingsAccount()
    {
        var acc = new SavingsAccount();
        acc.Id = ++seed + 200000000;
        return acc;
    }

    public static bool Transfer(this Account source,decimal amount, Account target)
    {
        if(ReferenceEquals(source,target))
            return false;
        source.Withdraw(amount);
        target.Deposit(amount);
        return true;
    }
}
