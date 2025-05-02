using DemoApp;

class Program
{
    static void Main(string[] args)
    {
        
    Employee[] employees = new Employee[4];

    employees[0] = new Employee(26000);
    employees[1] = new Manager(10000,8,9);
    employees[2] = new Employee(55000);
    employees[3] = new Manager(15000,5,7);

    foreach(var emp in employees)
    {
        Console.WriteLine(emp.ToString());
        Console.WriteLine("Annual Income = {0:0.00}",emp.AnnualIncome());
        Console.WriteLine("Tax = {0:0.00}",Tax.GlobalTax(emp));
        Console.WriteLine("----------------------");
    }

    }
}