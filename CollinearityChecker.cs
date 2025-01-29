using System;

public class CollinearityChecker
{
    // Method to calculate the slope between two points
    public static double CalculateSlope(double x1, double y1, double x2, double y2)
    {
        return (y2 - y1) / (x2 - x1);
    }

    // Method to check if three points are collinear using the slope formula
    public static bool ArePointsCollinearBySlope(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double slopeAB = CalculateSlope(x1, y1, x2, y2);
        double slopeBC = CalculateSlope(x2, y2, x3, y3);
        double slopeAC = CalculateSlope(x1, y1, x3, y3);

        // If all slopes are equal, points are collinear
        return (slopeAB == slopeBC) && (slopeAB == slopeAC);
    }

    // Method to check if three points are collinear using the area of triangle formula
    public static bool ArePointsCollinearByArea(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
        return area == 0;
    }

    public static void Main(string[] args)
    {
        // Take user input for the 3 points (x1, y1), (x2, y2), (x3, y3)
        Console.WriteLine("Enter the coordinates of the first point (x1, y1): ");
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the coordinates of the second point (x2, y2): ");
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the coordinates of the third point (x3, y3): ");
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());

        // Check collinearity using slope method
        bool areCollinearBySlope = ArePointsCollinearBySlope(x1, y1, x2, y2, x3, y3);
        if (areCollinearBySlope)
        {
            Console.WriteLine("The points are collinear using the slope method.");
        }
        else
        {
            Console.WriteLine("The points are NOT collinear using the slope method.");
        }

        // Check collinearity using area method
        bool areCollinearByArea = ArePointsCollinearByArea(x1, y1, x2, y2, x3, y3);
        if (areCollinearByArea)
        {
            Console.WriteLine("The points are collinear using the area method.");
        }
        else
        {
            Console.WriteLine("The points are NOT collinear using the area method.");
        }
    }
}
