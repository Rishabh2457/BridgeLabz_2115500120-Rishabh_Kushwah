using System;

class QuotientRemainderCalculator
{
    public static void Main(string[] args)
    {
        CalculateQuotientRemainder();
    }

    // Method to calculate quotient and remainder
    public static void CalculateQuotientRemainder()
    {
        Console.Write("Enter the first num: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second num: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Calculating quotient and remainder
        int quotient = num1 / num2;
        int remainder = num1 % num2;

        // Displaying the result
        Console.WriteLine(string.Format(
            "The Quotient is {0} and Remainder is {1} of two nums {2} and {3}.",
            quotient, remainder, num1, num2));
    }
}
