using System;

class DisConverter
{
    public static void Main(string[] args)
    {
        Convertdis();
    }

    // Method to convert dis from feet to yards and miles
    public static void Convertdis()
    {
        Console.Write("Enter the dis in feet: ");
        double disInFeet = Convert.ToDouble(Console.ReadLine());

        // Conversion calculations
        double disInYards = disInFeet / 3;
        double disInMiles = disInYards / 1760;

        // Displaying the results
        Console.WriteLine(string.Format(
            "The dis in feet is {0} which is equal to {1:F2} yards and {2:F4} miles.",
            disInFeet, disInYards, disInMiles));
    }
}
