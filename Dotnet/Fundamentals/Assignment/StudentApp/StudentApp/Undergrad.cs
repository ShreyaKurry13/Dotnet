namespace StudentApp;

public class Undergrad : Student
{
    public Undergrad(string n, int age, string a) : base(n, age, a)
    {
    }

    public override bool isPassed(double grade)
    {
        if (grade > 70)
        {
            return true;
        }
        return false;
    }
}