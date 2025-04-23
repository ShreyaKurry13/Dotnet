namespace DemoApp;

class Program
{
    static double SafeSchema(int period)
    {
        return period < 3 ? 5.5 : 6;
    }

    static void Main(string[] args)
    {
        double p = double.Parse(args[0]);
        int n = int.Parse(args[1]);

        var a = new Investment(p, n);
        Console.WriteLine("Future value for riskless investment: {0:0.00}",a.FutureValue(SafeSchema));
        Console.WriteLine("Future value for riskful investment: {0:0.00}",a.FutureValue(y => 8 + 0.25 * y));

    }
}