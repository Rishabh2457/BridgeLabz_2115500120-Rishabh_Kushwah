using System;

class LargestNum
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
		
		bool isFirstLargest = num1>num2 && num1>num3;
		bool isSecLargest = num2>num3 && num2>num1;
		bool isThirdLargest = num3>num1 && num3>num2;
		
		Console.WriteLine(string.Format("Is the first number the largest? {0}\nIs the second number the largest? {1}\nIs the third number the largest? {2}",isFirstLargest,isSecLargest,isThirdLargest));
													
	}
} 