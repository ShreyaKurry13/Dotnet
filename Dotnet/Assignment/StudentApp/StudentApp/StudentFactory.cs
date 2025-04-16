namespace StudentApp;

public static class StudentFactory
{
    public static Student OpenUnderGrad(string n, int age, string a)
    {
        var ug = new Undergrad(n,age,a);
        return ug;
    }

    public static Student OpenGrad(string n, int age, string a)
    {
        var gg = new Grad(n,age,a);
        return gg;
    }
}