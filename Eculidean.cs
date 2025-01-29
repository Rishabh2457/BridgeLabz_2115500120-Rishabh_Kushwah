using System;

class Euclidean
{
    public static double CalculateDistance(double x1, double y1, double x2, double y2)
    {
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return distance;
    }

    public static double[] CalculateLine(double x1, double y1, double x2, double y2)
    {
        // Calculate slope
        double m = (y2 - y1) / (x2 - x1);
        // Calculate intercept
        double b = y1 - m * x1;
        return new double[] { m, b };
    }

    static void Main(string[] args)
    {
        // Input for the two points
        Console.Write("Enter x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        // Calculate and display the Euclidean distance
        double distance = CalculateDistance(x1, y1, x2, y2);
        Console.WriteLine(string.Format("Euclidean Distance between points: {0}", distance));

        // Calculate and display the equation of the line
        double[] lineEquation = CalculateLine(x1, y1, x2, y2);
        Console.WriteLine(string.Format("Equation of the line: y = {0}x + {1}", lineEquation[0], lineEquation[1]));
    }
}



