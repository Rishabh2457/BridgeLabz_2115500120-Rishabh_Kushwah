using System;

class CheckNaturalNum
{
	public static void Main(string[] args)
	{
		PrintNum();
	}
	
	public static void PrintNum()
	{//taking user input
		Console.Write("Enter the Number: ");
		int num = Convert.ToInt32(Console.ReadLine());
		//method to check and print the sum of the natural number
		if (num>0)
			{
				int sum = num*(num+1)/2;
				Console.WriteLine(string.Format("The sum of {0} natural numbers is {1}",num,sum));
				
			}
		else
		{
			Console.WriteLine(string.Format("The number {0} is not a natural number",num));
			
		}
	}
}