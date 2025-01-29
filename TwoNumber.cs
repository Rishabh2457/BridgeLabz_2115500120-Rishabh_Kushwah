using System;

class TwoNumber
{
    // Method to calculate the remainder and quotient
    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        // Initialize variables
        int quotient, remainder;
        
        // Operations
        quotient = number / divisor;
        remainder = number % divisor;

        return new int[] { remainder, quotient };
    }

    static void Main(string[] args)
    {
        // Input from user
        Console.Write("Enter the First number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int number2 = int.Parse(Console.ReadLine());

        // Call the method
        int[] result = FindRemainderAndQuotient(number1, number2);

        // Display output using string.Format
        Console.WriteLine(string.Format("Remainder: {0} Quotient: {1} of {2} and {3}", result[0], result[1], number1, number2));
    }
}
