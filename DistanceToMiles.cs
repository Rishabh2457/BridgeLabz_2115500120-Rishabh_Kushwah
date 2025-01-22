using System;

class DistanceToMiles
	{
		public static void Main(string[] args)
		{
			
			ConvertDis();
		}
		
		public static void ConvertDis()
		{
			Console.Write("Enter the distance in Kilometers : ");
			
			double km = Convert.ToDouble(Console.ReadLine());
			
			double miles = km/1.6;
			
			Console.WriteLine(string.Format("The total miles is {0} miles for the given {1} kilometers.",miles,km));
    }
}
			