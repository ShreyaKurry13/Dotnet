class Program
{
	static void Main(string[] args)
	{
		float n = float.Parse(args[0]);
		float p = float.Parse(args[1]);
		System.Console.WriteLine("The Addition is: {0}",Add.AddNum(n,p));
		System.Console.WriteLine("The Subtraction is: {0}",Add.Sub(n,p));
	}

}
