using System;

class FactorialCalculator2
{
    public static void Main(string[] args)
    {
        ComputeFactorial();
    }

    // Method to compute the factorial
    public static void ComputeFactorial()
    {
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the input is a positive integer
        if (number < 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        int factorial = 1;

        // Compute factorial using a for loop
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        // Print the result
        Console.WriteLine(string.Format("The factorial of {0} is {1}.", number, factorial));
    }
}
