using MetTours;

int d = int.Parse(args[0]);
int p = int.Parse(args[1]);

Type t = Type.GetType($"MetTours.{args[2]},MetTourLib",true);

dynamic policy = Activator.CreateInstance(t);

double s = policy.getPerDayRent(d,p);
Console.WriteLine("{0} policy for {1} persons and {2} days = {3}",t,p,d,s);


