namespace Taxation;

public struct Worker(int jobs) : ITaxPayer
{
    decimal ITaxPayer.AnnualIncome()
    {
        Console.WriteLine("Worker running...");
        return 180000 + 500 * jobs;
    }
}