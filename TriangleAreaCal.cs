using System;

class TriangleAreaCal
{
    public static void Main(string[] args)
    {
        CalculateArea();
    }

    // Method to calculate the area of a triangle
    public static void CalculateArea()
    {
        Console.Write("Enter the base of the triangle in cm: ");
        double baseCm = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the height of the triangle in cm: ");
        double heightCm = Convert.ToDouble(Console.ReadLine());

        // Area calculation in square cm
        double areaCm = 0.5 * baseCm * heightCm;

        // Conversion to square inches (1 cm² = 0.155 square inches)
        double areaInches = areaCm * 0.155;

        // Displaying the results
        Console.WriteLine(string.Format(
            "The area of the triangle with base {0} cm and height {1} cm is {2:F2} square centimeters and {3:F2} square inches.",
            baseCm, heightCm, areaCm, areaInches));
    }
}
