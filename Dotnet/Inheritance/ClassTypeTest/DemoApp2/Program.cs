Console.WriteLine("Welcome User!");

Interval a = new Interval(6,50);
Print("Interval a = ",a);

Interval b = new Interval(4,45);
Print("Interval b = ",b);

Print("Sum = ",a+b);

Interval c = new Interval(5,110);
Print("Interval c = ",c);

Interval d = b;
Print("Interval d = ",d);

Console.WriteLine("a is identical to b: {0}",ReferenceEquals(a,b));
Console.WriteLine("a is identical to c: {0}",ReferenceEquals(a,c));
Console.WriteLine("d is identical to b: {0}",ReferenceEquals(d,b));
Console.WriteLine("-------------------------------");
Console.WriteLine("a is equals to b: {0}",Equals(a,b));
Console.WriteLine("a is equals to c: {0}",Equals(a,c));
Console.WriteLine("d is equals to b: {0}",Equals(d,b));


Box e = new Box {Length = 12.5f, Breadth = 8.5f, Height = 7.5f };
Print("Box e", e);

void Print(string label, object info)
{
    Console.WriteLine("{0} = {1}", label ,info);
}