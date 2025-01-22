using System;

class SimpleInterestCalculator
{
    public static void Main(string[] args)
    {
        CalculateSimpleInterest();
    }

    // Method to calculate Simple Interest
    public static void CalculateSimpleInterest()
    {
        // Taking user input 
        Console.Write("Enter the Principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Rate of Interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Time period (in years): ");
        double time = Convert.ToDouble(Console.ReadLine());

        // Calculating Simple Interest
        double simpleInterest = (principal * rate * time) / 100;

        // Displaying the result
        Console.WriteLine(string.Format(
            "The Simple Interest is {0} for Principal {1}, Rate of Interest {2}, and Time {3} years.",simpleInterest, principal, rate, time));
    }
}
