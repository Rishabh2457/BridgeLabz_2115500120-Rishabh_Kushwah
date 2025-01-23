using System;

class NaturalNumberSum
{
    public static void Main(string[] args)
    {
        CalculateAndCompareSum();
    }
    
    // Method to calculate and compare the sum of natural numbers
    public static void CalculateAndCompareSum()
    {
        Console.Write("Enter a natural number (greater than 0): ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Check if the input is a natural number
        if (n <= 0)
        {
            Console.WriteLine("Please enter a valid natural number (greater than 0).");
            return;
        }

        // Calculate sum using the formula
        int formulaSum = n * (n + 1) / 2;

        // Calculate sum using a while loop
        int loopSum = 0, i = 1;
        while (i <= n)
        {
            loopSum += i;
            i++;
        }

        // Compare and display results
        Console.WriteLine(string.Format("Sum using formula: {0}", formulaSum));
        Console.WriteLine(string.Format("Sum using while loop: {0}", loopSum));

        if (formulaSum == loopSum)
        {
            Console.WriteLine("Both computations match. The result is correct!");
        }
        else
        {
            Console.WriteLine("The computations do not match. Please check for errors.");
        }
    }
}
