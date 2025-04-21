namespace DemoApp;

class Program
{
    [ThreadStatic]
    static string manager;
   
    static void Handlejob(int jobno)
    {
        // Console.WriteLine("Hello, World!");
        Console.WriteLine("Thread<{0}> accepted job<{1}> for {2}",Environment.CurrentManagedThreadId,jobno,manager);
        Activity.Perform(jobno);
        Console.WriteLine("Thread<{0}> finished job<{1}> for {2}",Environment.CurrentManagedThreadId,jobno,manager);
    }

    static void Main(string[] args)
    {
        int n = args.Length > 0 ? int.Parse(args[0]) : 1;

        Thread child = new Thread(() =>
        {   
            manager = "Jack";
            Handlejob(n);
        });
        child.Start();
        manager = "Jill";
        Handlejob(2);
    }
}