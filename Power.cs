using System;

class Power
{
    static void Main(string[] args)
    {
        // Input the number and power from the user (as double for decimal values)
        Console.Write("Enter the number: ");
        double number = double.Parse(Console.ReadLine());

        Console.Write("Enter the power: ");
        int power = int.Parse(Console.ReadLine());

        // Initialize the result variable to 1.0 (double)
        double result = 1.0;

        // Calculate the power using a for loop
        for (int i = 1; i <= power; i++)
        {
            result *= number; // Multiply result by the number in each iteration
        }

        // Display the result
        Console.WriteLine(string.Format("{0} raised to the power of {1} is {2}.", number, power, result));
    }
}
