using System;

class SimpleInterest
{
    // Method to calculate the simple interest using principal, rate, time
    public double CalculateSimpleInterest(double principal, double rate, double time)
    {
        double simpleInterest = (principal * rate * time) / 100;
        return simpleInterest;
    }

    static void Main(string[] args)
    {
        // Input from user
        Console.Write("Enter the Principal Amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the Rate of Interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the Time Period: ");
        double time = Convert.ToDouble(Console.ReadLine());

        // Call the class instance
        SimpleInterest interest = new SimpleInterest();
        // Call the method
        double simpleInterest = interest.CalculateSimpleInterest(principal, rate, time);

        // Display the output using string.Format
        Console.WriteLine(string.Format("The Simple Interest is {0} for Principal {1}, Rate of interest {2} and Time {3}",
            simpleInterest, principal, rate, time));
    }
}