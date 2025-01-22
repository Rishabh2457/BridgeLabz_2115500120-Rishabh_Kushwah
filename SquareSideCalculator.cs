using System;

class SquareSideCalculator
{
    public static void Main(string[] args)
    {
        CalculateSquareSide();
    }

    // Method to calculate the side of a square from its perimeter
    public static void CalculateSquareSide()
    {
        // Taking user input for the perimeter of the square
        Console.Write("Enter the perimeter of the square: ");
        double perimeter = Convert.ToDouble(Console.ReadLine());

        // Calculating the side of the square (side = perimeter / 4)
        double side = perimeter / 4;

        // Displaying the result
        Console.WriteLine(string.Format(
            "The length of the side is {0} whose perimeter is {1}.", 
            side, perimeter));
    }
}
