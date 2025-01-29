using System;

class UnitConverter
{
    // Method to convert fahrenheit to celsius
    public static double ConvertFarhenheitToCelsius(double farhenheit)
    {
        return ((farhenheit - 32) * 5) / 9;
    }

    // Method to convert celsius to fahrenheit
    public static double ConvertCelsiusToFarhenheit(double celsius)
    {
        return ((celsius * 9) / 5) + 32;
    }

    // Method to convert pounds to kilogram
    public static double ConvertPoundsToKilogram(double pounds)
    {
        return pounds * 0.453592;
    }

    // Method to convert kilogram to pounds
    public static double ConvertKilogramToPounds(double kilogram)
    {
        return kilogram * 2.20462;
    }

    // Method to convert gallons to liters
    public static double ConvertGallonsToLiters(double gallons)
    {
        return gallons * 3.78541;
    }

    // Method to convert liters to gallons
    public static double ConvertLitersToGallons(double liters)
    {
        return liters * 0.264172;
    }

    static void Main(string[] args)
    {
        // Input from user
        Console.Write("Enter the fahrenheit (to celsius): ");
        double farhenheit = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the celsius (to fahrenheit): ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the pounds (to kilogram): ");
        double pounds = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the kilograms (to pounds): ");
        double kilograms = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the gallons (to liters): ");
        double gallons = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the liters (to gallons): ");
        double liters = Convert.ToDouble(Console.ReadLine());

        // Display the output using string.Format
        Console.WriteLine(string.Format("{0} Fahrenheit in Celsius is {1}", farhenheit, ConvertFarhenheitToCelsius(farhenheit)));
        Console.WriteLine(string.Format("{0} Celsius in Fahrenheit is {1}", celsius, ConvertCelsiusToFarhenheit(celsius)));
        Console.WriteLine(string.Format("{0} pounds in kilograms is {1}", pounds, ConvertPoundsToKilogram(pounds)));
        Console.WriteLine(string.Format("{0} kilograms in pounds is {1}", kilograms, ConvertKilogramToPounds(kilograms)));
        Console.WriteLine(string.Format("{0} gallons in liters is {1}", gallons, ConvertGallonsToLiters(gallons)));
        Console.WriteLine(string.Format("{0} liters in gallons is {1}", liters, ConvertLitersToGallons(liters)));
    }
}
