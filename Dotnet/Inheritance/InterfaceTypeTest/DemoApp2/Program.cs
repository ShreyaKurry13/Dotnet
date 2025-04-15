using Taxation;

namespace DemoApp;

class Program
{
    class Auditor : IDisposable
    {
        public Auditor()
        {
            Console.WriteLine("Auditor - starting...");
        }

        public void Audit(string id,ITaxPayer payer)
        {
            Console.WriteLine($"Auditing {id}...");
            if(id.Length < 4)
                throw new ArgumentException("Invalid ID");
            decimal payment = payer.Income() +150;
            Console.WriteLine($"Tax payment: {payment}");
        }

        public void Dispose()
        {
            Console.WriteLine("Auditor - ending...");
        }
    }

    static void DoAuditing(string name, int count)
    {
        using(var a = new Auditor())
        {
            if(count > 10)
                 a.Audit(name ,new Worker(count));
            else
                a.Audit(name, new Supervisor(count));
        }
    }

    static void Main(string[] args)
    {
        try
        {
            string m = args[0].ToUpper();
            int n = int.Parse(args[1]);
            DoAuditing(m, n);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
