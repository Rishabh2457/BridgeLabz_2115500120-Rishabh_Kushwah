using System;

// Circle Class
class Circle
{
    private double radius;

    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    // Default Constructor (Chaining Corrected)
    public Circle() : this(1.0) { }

    // Parameterized Constructor
    public Circle(double radius)
    {
        Radius = radius;
    }

    // Calculate Area
    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    // Calculate Circumference
    public double GetCircumference()
    {
        return 2 * Math.PI * Radius;
    }

    // Display Circle Details
    public void Display()
    {
        Console.WriteLine(string.Format("Circle Radius: {0}", Radius));
        Console.WriteLine(string.Format("Area: {0:F2}", GetArea()));
        Console.WriteLine(string.Format("Circumference: {0:F2}", GetCircumference()));
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle defaultCircle = new Circle(); // Uses default constructor
        Console.WriteLine("Default Circle:");
        defaultCircle.Display();
        Console.WriteLine();

        Circle customCircle = new Circle(2.34); // Uses parameterized constructor
        Console.WriteLine("Custom Circle:");
        customCircle.Display();
    }
}
