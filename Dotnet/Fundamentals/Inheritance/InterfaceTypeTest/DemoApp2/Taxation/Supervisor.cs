namespace Taxation;

public struct Supervisor(int subordinates) : ITaxPayer
{
    decimal ITaxPayer.AnnualIncome()
    {
        Console.WriteLine("Supervisor running...");
        return 480000 + 5000 * subordinates;
    }
}