using System;

class TemperatureConversion2
{
    public static void Main(string[] args)
    {
        ConvertFahrenheitToCelsius();
    }

    // Method to convert Fahrenheit to Celsius
    public static void ConvertFahrenheitToCelsius()
    {
        // Taking user input
        Console.Write("Enter the temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        // Converting Fahrenheit to Celsius
        double celsiusResult = (fahrenheit - 32) * 5 / 9;

        // Displaying the result
        Console.WriteLine(string.Format("{0} Fahrenheit is {1} Celsius.",fahrenheit, celsiusResult));
    }
}
