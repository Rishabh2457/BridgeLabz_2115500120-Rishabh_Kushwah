using System;

class SmallestNum
{
	public static void Main(string[] args)
	{
		CheckSmallest();
	}
	
	public static void CheckSmallest()
	{
		Console.Write("Enter the 1st number: ");
		int num1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter the 2nd number: ");
		int num2 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter the 3rd number: ");
		int num3 = Convert.ToInt32(Console.ReadLine());
		
		bool isSmallest = num1<num2 && num1<num3;
		
		Console.WriteLine(string.Format("Is the first number the smallest? {0}",isSmallest));
		
	}
}