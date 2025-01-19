using System;

namespace TemperatureConversion
{
    class CtoF
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature in Celsius:");
            string input = Console.ReadLine();
            double celsius = Convert.ToDouble(input);

            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine("{0}° Celsius is equal to {1}° Fahrenheit.", celsius, fahrenheit);
        }
    }
}
