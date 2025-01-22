using System;

class Vol
	{
		public static void Main(string[] args)
		{
			double radius =6378;
			double miles = 1.6;
			FindVol(radius,miles);
			
		}
		
		public static void FindVol(double radius,double miles)
		{
			double volumneOfEarth = (4.0/3.0)*Math.PI*Math.Pow(radius,3);
			double inMiles = volumneOfEarth*miles;
			Console.WriteLine(string.Format("The volume of earth in cubic kilometers is {0} and cubic miles is {1}",volumneOfEarth,inMiles));
		}
	}