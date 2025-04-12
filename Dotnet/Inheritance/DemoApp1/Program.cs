using Payroll;

class Program
{
    static double Tax(Employee emp)
    {
        double i = emp.Income();
        return i > 10000 ? 0.15 * (i - 10000) : 0;
    }

    static double Bonus(Employee? emp)
    {
        if(emp is null || emp is Salesperson)
            return 0;
        return 0.12 * emp.Income();
    }

    static void Main(string[] args)
    {
        Employee jack = new Employee();
        jack.Hours = 1255;
        jack.Rate = 50;
        Console.WriteLine("Jack's income = {0} and applicable Tax = {1} and Bonus = {2}",jack.Income(),Tax(jack),Bonus(jack));
        
        Salesperson shreya = new Salesperson(1255,50,15050);
        Console.WriteLine("Shreya's Income = {0} and applicable Tax = {1} and Bonus = {2}",shreya.Income(),Tax(shreya),Bonus(shreya));
    }
}