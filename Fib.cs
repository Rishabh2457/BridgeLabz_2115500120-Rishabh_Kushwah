uisng System;

class Fib{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter thr num : " );
		int num = int.Parse(Console.ReadLine());
		int n0 = 0 ;
		int n1 = 1;
		int n2 = 2;
		Console.Write(n0 + " " + n1 + " " + n2+" ");
		Fibonacci();
	}
	
	static int Fibonacci()
	{
		for(int i = 2 ; i<=num ;i++)
		{
			num = n2+n1;
			n1 = n2;
			n2 = num;
		}
		
	}
}
			
	