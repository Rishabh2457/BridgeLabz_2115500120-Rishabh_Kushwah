using System;

class TemperatureConversion
{
    public static void Main(string[] args)
    {
        ConvertCelsiusToFahrenheit();
    }

    // Method to convert Celsius to Fahrenheit
    public static void ConvertCelsiusToFahrenheit()
    {
        // Taking user input for Celsius
        Console.Write("Enter the temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        // Converting Celsius to Fahrenheit
        double fahrenheitResult = (celsius * 9 / 5) + 32;

        // Displaying the result
        Console.WriteLine(string.Format("{0} Celsius is {1} Fahrenheit.",celsius, fahrenheitResult));
    }
}
