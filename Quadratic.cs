using System;

public class Quadratic
{
    // Method to find the roots of the quadratic equation
    public static double[] FindRoots(double a, double b, double c)
    {
        // Calculate the discriminant (d)
        double d = Math.Pow(b, 2) - 4 * a * c;

        // If d is positive, calculate two roots
        if (d > 0)
        {
            double root1 = (-b + Math.Sqrt(d)) / (2 * a);
            double root2 = (-b - Math.Sqrt(d)) / (2 * a);
            return new double[] { root1, root2 }; // Return both roots
        }
        // If d is zero, there is only one root
        else if (d == 0)
        {
            double root = -b / (2 * a);
            return new double[] { root }; // Return the one root
        }
        // If d is negative, return an empty array (no real roots)
        else
        {
            return new double[0]; // No real roots
        }
    }

    public static void Main(string[] args)
    {
        // Take user input for a, b, and c
        Console.Write("Enter value for a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter value for b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter value for c: ");
        double c = double.Parse(Console.ReadLine());

        // Find the roots of the quadratic equation
        double[] roots = FindRoots(a, b, c);

        // Display the roots
        if (roots.Length == 2)
        {
            Console.WriteLine(string.Format("The roots of the quadratic equation are: root1 = {0}, root2 = {1}", roots[0], roots[1]));
        }
        else if (roots.Length == 1)
        {
            Console.WriteLine(string.Format("The root of the quadratic equation is: root = {0}", roots[0]));
        }
        else
        {
            Console.WriteLine("The quadratic equation has no real roots.");
        }
    }
}
