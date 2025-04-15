using Banking;

Account jill = Banker.OpenSavingsAccount();
jill.Deposit(15000);

Account jack = Banker.OpenCurrentAccount();
jack.Deposit(30000);

Account shreya = Banker.OpenSavingsAccount();
shreya.Deposit(35000);


Console.WriteLine("Jill's Account ID = {0} and Balance = {1}",jill.Id,jill.Balance);
Console.WriteLine("Jack's Account ID is {0} and Balance = {1}", jack.Id, jack.Balance);
Console.WriteLine("Shreya's Account ID = {0} and Balance = {1}",shreya.Id,shreya.Balance);

    if(args.Length > 0)
    {
        try
        {
            decimal payment = decimal.Parse(args[0]);
            Console.WriteLine("Jill is paying {0} to Jack",payment);
            jill.Transfer(payment,jack);
            Console.WriteLine("Payment Successful");
        }
        catch(InsufficientFundsException)
        {
            Console.WriteLine("Payment failed due to insufficient funds");
            jill.Freeze();
        }
        catch(Exception ex)
        {
            Console.WriteLine("Error : {0}",ex.Message);
        }
    }
    else
    {
        Console.WriteLine("Paying annual interest to all accounts");
        PayInterest(4, jill , jack, shreya);
    }


Console.WriteLine("Jill's final balance = {0}",jill.Balance);
Console.WriteLine("Jack's final balance = {0}",jack.Balance);
Console.WriteLine("Shreya's final balance = {0}",shreya.Balance);