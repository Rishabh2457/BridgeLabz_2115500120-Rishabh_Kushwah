using System;

class FindAge{
	public static void Main(string[] args)
	{
		int birthYr = 2000;
		int currYr = 2024;
		int age = currYr-birthYr;
		Console.WriteLine(string.Format("Harry's age in {0} is {1}",currYr,age));
		}
	}