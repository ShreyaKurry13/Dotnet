namespace StudentApp;

public class Grad : Student
{
    public Grad(string n, int age, string a) : base(n, age, a)
    {
    }

    public override bool isPassed(double grade)
    {
        if( grade > 80)
        {
            return true;
        }
        return false;
    }
}