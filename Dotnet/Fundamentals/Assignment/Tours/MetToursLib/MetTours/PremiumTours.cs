namespace MetTours;

public class PremiumTours
{
    public double getPerDayRent(int days , int persons)
    {
        double fcharge = 1200 * persons;

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