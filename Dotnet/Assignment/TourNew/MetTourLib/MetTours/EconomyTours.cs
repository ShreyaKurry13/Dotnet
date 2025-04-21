namespace MetTours;
public class EconomyTours{
public double getPerDayRent(int days , int noPersons)
    {
        double drent = 500 * noPersons;

        if(days > 4){
            drent = drent - 200;
        }

        if(days > 2){
            drent = drent - 100;
        }
    }
}