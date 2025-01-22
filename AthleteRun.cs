using System;

class AthleteRun
{
    public static void Main(string[] args)
    {
        CalculateRounds();
    }

    // Method to calculate the number of rounds 
    public static void CalculateRounds()
    {
        // Taking user input for the sides of the triangle
        Console.Write("Enter the length of side 1 of the triangle (in meters): ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 2 of the triangle (in meters): ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 3 of the triangle (in meters): ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        // Calculating the perimeter
        double perimeter = side1 + side2 + side3;

        // Total distance the athlete wants to complete (5 km = 5000 meters)
        double totalDistance = 5000; // in meters

        // Calculating the number of rounds required to complete 5 km
        double rounds = totalDistance / perimeter;

        // Displaying the number of rounds the athlete needs to run
        Console.WriteLine(string.Format(
            "The total number of rounds the athlete will run is {0} to complete 5 km.",
            Math.Ceiling(rounds))); // Use Math.Ceiling to round up to the next whole number
    }
}
