using System;

class AveragePer{
	public static void Main(string[] args)
	{
	int mathNo = 94;
	int physicsNo = 95;
	int chemistryNo = 96;
	double AveragePercantage = (mathNo+physicsNo+chemistryNo)/3;
	
	Console.WriteLine(string.Format("Sam's average marks in PCM is {0}%",AveragePercantage));
	}
}
