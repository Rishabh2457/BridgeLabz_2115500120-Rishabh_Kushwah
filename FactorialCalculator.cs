using System;

class FactorialCalculator
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
        int i = 1;

        // Compute factorial using a while loop
        while (i <= number)
        {
            factorial *= i;
            i++;
        }

        // Print the result
        Console.WriteLine(string.Format("The factorial of {0} is {1}.", number, factorial));
    }
}
