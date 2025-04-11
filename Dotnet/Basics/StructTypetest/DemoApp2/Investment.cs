enum RiskLevel {None,Low,High}

struct Investment
{
    private double installment;
    private int years;
    private RiskLevel risk;
    
    public Investment(double amt,int period)
    {
        installment = amt;
        years = period;
        risk = RiskLevel.None;
    }

    public void AllowRisk(bool yes)
    {
        risk = yes ? RiskLevel.Low : RiskLevel.None;
    }

    public void AllowRisk(RiskLevel level)
    {
        risk = level;
    }

    public double TotalPayment()
    {
        return installment * years;
    }

    public double FutureValue()
    {
        double i;
        switch(risk)
        {
            case RiskLevel.Low:
                i = 0.08;
                break;
            case RiskLevel.High:
                i = 0.12;
                break;    
            default:
                i = 0.06;
                break;
        }
        return (installment / i) * (System.Math.Pow(1+i,years) - 1);
    }
}