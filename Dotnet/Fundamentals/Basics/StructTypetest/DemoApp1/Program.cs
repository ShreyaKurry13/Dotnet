using System;

class Program
{

    static void Advise(ref Investment inv)
    {
        inv.AllowRisk(inv.TotalPayment() < 500000);
    }

    static void Main(string[] args)
    {
        double a = double.Parse(args[0]);
        int p = int.Parse(args[1]);

        Investment n = new Investment(a ,p);
        Console.WriteLine("Future value of riskless investment = {0:0.000}",n.FutureValue());
        
        n.AllowRisk(true);
        Console.WriteLine("Future value of low-risk investment = {0:0.000}",n.FutureValue());

        Advise(ref n);
        Console.WriteLine("Future value of smart investment = {0:0.000}",n.FutureValue());
    }
}