using System;

class UnitConverter
{
    // Method to convert km to miles
    public static double ConvertKmToMiles(double km)
    {
        return km * 0.621371;
    }

    // Method to convert miles to km
    public static double ConvertMilesToKm(double miles)
    {
        return miles * 1.60934;
    }

    // Method to convert meters to feet
    public static double ConvertMetersToFeet(double meters)
    {
        return meters * 3.28084;
    }

    // Method to convert feet to meters
    public static double ConvertFeetToMeters(double feet)
    {
        return feet * 0.3048;
    }

    static void Main(string[] args)
    {
        // Input from user
        Console.Write("Enter the kilometers: ");
        double kilometers = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the miles: ");
        double miles = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the meters: ");
        double meters = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the feet: ");
        double feet = Convert.ToDouble(Console.ReadLine());

        // Display the output
        Console.WriteLine(string.Format("{0} km in miles is {1:F2}", kilometers, ConvertKmToMiles(kilometers)));
        Console.WriteLine(string.Format("{0} miles in kilometers is {1:F2}", miles, ConvertMilesToKm(miles)));
        Console.WriteLine(string.Format("{0} meters in feet is {1:F2}", meters, ConvertMetersToFeet(meters)));
        Console.WriteLine(string.Format("{0} feet in meters is {1:F2}", feet, ConvertFeetToMeters(feet)));
    }
}



