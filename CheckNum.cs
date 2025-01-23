using System;

class CheckNum{
	public static void Main(string[] args)
	{
		CheckNumber();
	}
	//methode to check the number is positive ,negative or zero
	
	public static void CheckNumber()
	{
		Console.Write("Enter the number : " );
		int num = Convert.ToInt32(Console.ReadLine());
		
		if (num>0)
		{
			Console.WriteLine("Positive");
		}
		else if (num<0)
		{
			Console.WriteLine("Negative");
		}
		else 
		{
			Console.WriteLine("Zero");
		}
	}

}
			
		