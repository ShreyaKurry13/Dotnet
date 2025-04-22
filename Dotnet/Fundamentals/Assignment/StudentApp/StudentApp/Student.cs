namespace StudentApp;

public abstract class Student
{
    private static int sid = 1000;
    public string Name { get; set; }
    public int Id { get; internal set; }
    public int Age { get; set; }
    public string Address { get; set; }

    public Student(string n, int age, string a)
    {
        Name = n;
        Age = age;
        Id = ++sid;
        Address = a;
    }
    public abstract bool isPassed(double grade);

}
