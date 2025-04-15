namespace Taxation;

public interface ITaxPayer
{
    decimal AnnualIncome();

    decimal Income()
    {
        decimal i = AnnualIncome();
        return i > 200000 ? 0.15M * (i - 200000) : 0;
    }
}