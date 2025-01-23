using System;

class SumUntilZeroOrNegative
{
    public static void Main(string[] args)
    {
        CalculateSum();
    }
    
    // Method to calculate the sum until the user enters 0 or a negative number
    public static void CalculateSum()
    {
        double total = 0.0; // Initialize total to 0.0

        while (true)
        {
            Console.Write("Enter a number (0 or negative to stop): ");
            double userInput = Convert.ToDouble(Console.ReadLine());

            // Check if the input is 0 or negative, and break the loop if so
            if (userInput <= 0)
            {
                break;
            }

            // Add the input to the total
            total += userInput;
        }

        // Display the total sum using string.Format
        Console.WriteLine(string.Format("The total sum is {0}", total));
    }
}
