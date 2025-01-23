using System;

class CheckVoter
{
	public static void Main(string[] args)
	{
		Voting();
	}
	
	public static void Voting()
	{
		Console.Write("Enter your age : ");
		int age = Convert.ToInt32(Console.ReadLine());
		
		if(age>18)
		{
			Console.WriteLine(string.Format("The person's age is {0} and can vote.",age));
		}
		else
		{
			Console.WriteLine(string.Format("The person's age is {0} and cannot vote.",age));
		}
		
	}
	
}


			