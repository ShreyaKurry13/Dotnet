struct Investment{
    private double installment;
    private int years;
    private bool risk; 

    public Investment(double amount, int period)
    {
        installment = amount;
        years = period;
        risk = false;
    }

    public void AllowRisk(bool yes)
    {
        risk = yes;
    }

    public double TotalPayment()
    {
        return installment * years;
    }

    public double FutureValue()
    {
        double i = risk ? 0.08:0.06;
        return (installment / i) * (System.Math.Pow(1 + i,years) - 1);
    }
}