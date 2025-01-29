
using System;

class Triangle
{
    // Method to calculate the number of rounds using the sides and distance
    public static double CalculateRounds(double side1, double side2, double side3, int distance)
    {
        return distance / (side1 + side2 + side3);
    }

    static void Main(string[] args)
    {
        // Input from user
        Console.Write("Enter the first side of the triangle: ");
        double side1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the second side of the triangle: ");
        double side2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the third side of the triangle: ");
        double side3 = Convert.ToDouble(Console.ReadLine());
        
        int toRun = 5000;

        // Call the method
        double rounds = CalculateRounds(side1, side2, side3, toRun);

        // Display the output using string.Format
        Console.WriteLine(string.Format("The number of rounds to complete are: {0:0.000}", rounds));
    }
}



