class Program
{
    static void Main(string[] args)
    {
        //default constructor called
        Student s = new Student();
        Console.WriteLine(s);

        Console.WriteLine("----------------");

        // get and set values
        Student ak = new Student();
        ak.Rollno=10;
        ak.Age = 21;
        ak.Grade = 70;
        Console.WriteLine("AK Rollno = {0}",ak.Rollno);
        Console.WriteLine("AK Age = {0}",ak.Age);
        Console.WriteLine("AK Grade = {0}",ak.Grade);
        
        Console.WriteLine("----------------");

        //user defined values
        Console.WriteLine("Shreya's ID = ");  
        int r = int.Parse(Console.ReadLine());

        Console.WriteLine("Shreya's age = "); 
        int a = int.Parse(Console.ReadLine());

       Console.WriteLine("Shreya's Grade = "); 
       int g = int.Parse(Console.ReadLine()); 
       
        Student shi = new Student(r,a,g);
        Console.WriteLine("Shreya's Info---> {0}",shi);
    }
}