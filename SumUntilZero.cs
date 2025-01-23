using System;

class SumUntilZero
{
    public static void Main(string[] args)
    {
        CalculateSum();
    }
    
    // Method to calculate the sum of numbers until the user enters 0
    public static void CalculateSum()
    {
        double total = 0.0; // Initialize total to 0.0
        Console.Write("Enter a number (0 to stop): ");
        double userInput = Convert.ToDouble(Console.ReadLine()); // Initial input

        // Use while loop to check if userInput is not 0
        while (userInput != 0)
        {
            total += userInput; // Add the input to the total
            Console.Write("Enter another number (0 to stop): ");
            userInput = Convert.ToDouble(Console.ReadLine()); // Get the next input
        }

        // Display the total sum
        Console.WriteLine(string.Format("The total sum is {0}",total));
    }
}
