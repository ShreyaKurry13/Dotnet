using Banking;

partial class Program
{
    public static void PayInterest(int quaters ,params Account[] accounts)
    {
        foreach(Account acc in accounts)
        {
            IProfitable p = acc as IProfitable;
            p?.AddInterest(3 * quaters);
        }
    }
}

