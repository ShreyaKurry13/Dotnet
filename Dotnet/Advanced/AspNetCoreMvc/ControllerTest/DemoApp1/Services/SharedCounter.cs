namespace DemoApp.Services;

public class SharedCounter : IVisitCounter
{
    public static int current = 0;
    public int NextCount(string id)
    {
        return Interlocked.Increment(ref current);
    }
}