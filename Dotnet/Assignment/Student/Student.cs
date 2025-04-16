namespace Student;

public abstract class Student
{
    public string Name { get; set; }
    public int Id { get; set; }
    public int Age { get; set; }
    public double Grade { get; set; }
    public string Address { get; set; }

    public abstract bool isPassed(double grade);
}
