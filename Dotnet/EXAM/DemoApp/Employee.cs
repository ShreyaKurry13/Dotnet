namespace DemoApp;

//base class
class Employee
{
    private static int AutoId = 100;

    public int Id{get;}
    public double Salary{get; set;}

    public Employee(double sal)
    {
        Id = ++AutoId;
        Salary = sal;
    }

    public override string ToString()
    {
        return $"Id = {Id} , Salary = {Salary}";
    }

    public virtual double AnnualIncome()
    {
        return Salary *12;
    }
}

//derived class
class Manager : Employee
{
    public int Projects{get; set;}
    public int Subordinates{get; set;}

    public Manager(double sal,int proj,int sub) : base(sal)
    {
        Projects = proj;
        Subordinates = sub;
    }

    public override double AnnualIncome()
    {
        return base.AnnualIncome() + Projects * 20000 + Subordinates *10000;
    }

    public override string ToString()
    {
        return base.ToString() + $" , Projects = {Projects} , Subordinates = {Subordinates}";
    }
}

static class Tax
{
    public static double GlobalTax(this Employee emp)
    {
        double income = emp.AnnualIncome();
        double tax = 0;

        if(income > 500000)
        {
            tax = income * 0.2;
        }
        else if(income > 300000)
        {
            tax = income * 0.1;
        }
        
        if(emp is Employee)
        {
            tax -= tax * 0.025;
        }

        return tax;
    }

}