using Banking;

Account jill = Banker.OpenSavingsAccount();
jill.Deposit(15000);

Account jack = Banker.OpenCurrentAccount();
jack.Deposit(30000);

Account shreya = Banker.OpenSavingsAccount();
shreya.Deposit(25000);
shreya.Withdraw(2000);

Console.WriteLine("Jill's Account ID = {0} and Balance = {1}",jill.Id,jill.Balance);
Console.WriteLine("Jack's Account ID is {0} and Balance = {1}", jack.Id, jack.Balance);
Console.WriteLine("Shreya's Account ID = {0} and Balance = {1} after Withdraw = {2}",shreya.Id,shreya.Balance,shreya.Balance);

