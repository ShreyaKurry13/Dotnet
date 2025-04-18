namespace MetTours;

public class EconomyTours 
{
    public double getPerDayRent(int days , int persons)
    {
        double fcharge = 500 * persons;

        if(days > 4)
        {
            fcharge = fcharge -200;
        }

        if(days > 2)
        {
            fcharge = fcharge - 100;
        }

        return fcharge;
    }
}