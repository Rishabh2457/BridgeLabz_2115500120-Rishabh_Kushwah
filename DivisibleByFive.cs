using System;

class DivisibleByFive
{
	public static void Main(string[] args)
	{
		FiveDivisible();
	}
	
	public static void FiveDivisible()
	{
		//taking user inputs
		Console.Write("Enter the number : ");
		int num = Convert.ToInt32(Console.ReadLine());
		
		//checking if the given number is divisible by 5 or not
		bool isdivisible = num%5==0;
		
		Console.WriteLine(string.Format("Is the number {0} divisible by 5? {1}",num,isdivisible));
	}

}
			