using Common;

namespace DemoApp;

class  Program
{
    static void Main(string[] args)
    {
        SimpleStack<string> a = new SimpleStack<string>();
        a.Push("Monday");
        a.Push("Tuesday");
        a.Push("Wednesday");
        a.Push("Thursday");
        a.Push("Friday");

        while(!a.Empty())
            Console.WriteLine(a.Pop());
        Console.WriteLine("--------------");

        SimpleStack<Interval> p = new SimpleStack<Interval>();
        p.Push(new Interval(3,55));
        p.Push(new Interval(4,11));
        p.Push(new Interval(5,22));
        p.Push(new Interval(6,00));
        p.Push(new Interval(7,22));
        p.Push(new Interval(8,33));

        while(!p.Empty())
            Console.WriteLine(p.Pop());
    }
}
