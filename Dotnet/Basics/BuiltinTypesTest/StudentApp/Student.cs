class Student
{
    private int rollno;
    private int age;
    private int grade;

    public Student(int r, int a,int g)
    {
        rollno = r;
        age = a;
        grade = g;
    }

    public Student() : this(1, 22 ,70)
    {

    }

    public int Rollno{get; set;}
    public int Age{get; set;} 
    public int Grade{get; set;}   

    public override string ToString()
    {
        return "ID: "+ rollno+ " Age: " + age+ " Grade: " + grade;
    }
}