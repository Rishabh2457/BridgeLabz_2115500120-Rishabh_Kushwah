using System;

class SampleProgram2
{
    public static void Main(string[] args)
    {
        TripDetails();
    }

    // Method to input and display trip details
    public static void TripDetails()
    {
        // Taking user input for name and cities
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your departure city: ");
        string fromCity = Console.ReadLine();

        Console.Write("Enter your via city: ");
        string viaCity = Console.ReadLine();

        Console.Write("Enter your destination city: ");
        string toCity = Console.ReadLine();

        // Taking user input for distances in miles
        Console.Write("Enter the distance from " + fromCity + " to " + viaCity + " in miles: ");
        double fromToVia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the distance from " + viaCity + " to " + toCity + " in miles: ");
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

        // Taking user input for time taken for the journey in hours
        Console.Write("Enter the total time taken for the journey in hours: ");
        double timeTaken = Convert.ToDouble(Console.ReadLine());

        // Calculating total distance and average speed
        double totalDistance = fromToVia + viaToFinalCity;
        double averageSpeed = totalDistance / timeTaken;

        // Displaying the results
        Console.WriteLine(string.Format(
            "The results of the trip are: Name: {0},From City: {1},Via City: {2},To City: {3},Total Distance: {4} miles,Average Speed: {5} miles/hour", 
            name, fromCity, viaCity, toCity, totalDistance, averageSpeed));
    }
}
