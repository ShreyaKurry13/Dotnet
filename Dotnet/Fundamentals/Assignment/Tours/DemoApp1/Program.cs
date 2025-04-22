using MetTours; 

Console.WriteLine("Hello, World!");

int d = int.Parse(args[0]);
int p = int.Parse(args[1]);

Type t = Type.GetType($"MetTours.{args[2]},MetToursLib" , true);
dynamic policy = Activator.CreateInstance(t);

double s = policy.getPerDayRent(d,p);
Console.WriteLine("{0} for {1} persons = {2}",t,p,s);

