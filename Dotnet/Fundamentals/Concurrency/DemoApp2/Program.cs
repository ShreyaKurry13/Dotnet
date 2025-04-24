namespace DemoApp;

class Program
{
    class JointAccount
    {
        public int Balance { get; private set; }

        public bool Debit(int amount)
        {
            bool success = false;
            Monitor.Enter(this);
            try
            {
                if(Balance >= amount)
                {
                    Balance = Activity.Perform(Balance, amount, -1);
                    success = true;
                }
            }
            finally
            {
                Monitor.Exit(this); 
            }
            return success;
        }

        public void Credit(int amount)
        {
            lock(this)
            {
                Balance = Activity.Perform(Balance, amount, 1);
                Monitor.Pulse(this); 
            }
        }

        public bool DebitAfterCredit(int amount)
        {
            lock(this)
            {
                Monitor.Wait(this);
                return Debit(amount);
            }
        }
    }

    static void Main(string[] args)
    {
        JointAccount acc = new(); 
        acc.Credit(10000);
        Console.WriteLine("Joint account opened for Jack and Jill");
        Console.WriteLine("Initial Balance = {0}", acc.Balance);
        Thread first = new Thread(() =>
        {
            Console.WriteLine("Jack debits 6000...");
            if(!acc.Debit(6000))
                Console.WriteLine("Jack's transaction failed!");
        });
        first.Start();
        Thread second = new Thread(() =>
        {
            Console.WriteLine("Jill debits 7000...");
            if(!acc.Debit(7000))
                Console.WriteLine("Jill's transaction failed!");
        });
        second.Start();
        first.Join(); 
        second.Join(); 
        Console.WriteLine("Final Balance = {0}", acc.Balance);
    }
}