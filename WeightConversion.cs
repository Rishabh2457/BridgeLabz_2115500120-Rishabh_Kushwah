using System;

class WeightConversion
{
    public static void Main(string[] args)
    {
        ConvertWeight();
    }

    // Method to convert weight from pounds to kilograms
    public static void ConvertWeight()
    {
        // Taking user input for weight in pounds
        Console.Write("Enter the weight in pounds: ");
        double weightInPounds = Convert.ToDouble(Console.ReadLine());

        // Conversion factor: 1 pound = 2.2 kg
        double weightInKg = weightInPounds * 2.2;

        // Displaying the result
        Console.WriteLine(string.Format(
            "The weight of the person in pounds is {0} and in kg is {1}.", 
            weightInPounds, weightInKg));
    }
}
