using System;

class BasicCalculator
{
    public static void Main(string[] args)
    {
        PerformCalculations();
    }

    // Method to perform basic arithmetic operations
    public static void PerformCalculations()
    {
        // Taking user inputs
        Console.Write("Enter the first num: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the second num: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Performing arithmetic operations
        double add = num1 + num2;
        double sub = num1 - num2;
        double mul = num1 * num2;
        double div = num2 != 0 ? num1 / num2 : double.NaN; // Handle division by zero

        // Displaying the results
        Console.WriteLine(string.Format(
            "The addition, subtraction, multiplication and division value of 2 nums {0} and {1} is {2}, {3}, {4}, and {5}",
            num1, num2, add, sub, mul, div));
    }
}
