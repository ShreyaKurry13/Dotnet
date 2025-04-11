using System;
class Program
{
    static void Advise(ref Investment inv)
    {
        inv.AllowRisk(inv.TotalPayment() < 500000);
    }

    public static bool TryPremiumScheme(double amt,out Investment inv)
    {
        if(amt < 100000)
        {
            inv = new Investment();
            return false;
        }
        inv = new Investment(amt , 5);
        if(amt >= 200000)
            inv.AllowRisk(RiskLevel.Low);
        else
            inv.AllowRisk(RiskLevel.High);
        return true;
    }

    static void Main(string[] args)
    {
        double p = double.Parse(args[0]);
        int n = int.Parse(args[1]);
        Investment a = new Investment(p, n);
        Console.WriteLine("Future value in riskless investment: {0:0.00}", a.FutureValue());
        a.AllowRisk(true);
        Console.WriteLine("Future value in low-risk investment: {0:0.00}", a.FutureValue());
         a.AllowRisk(RiskLevel.High);
        Console.WriteLine("Future value in high-risk investment: {0:0.00}", a.FutureValue());

        if(n==5 && TryPremiumScheme(p,out Investment s))
        {
            Console.WriteLine("Future value in premium investment: {0:0.00}", s.FutureValue());
        }
    }
}