using System;

class DoubleOpt
{
    public static void Main(string[] args)
    {
        PerformDoubleOperations();
    }

    // Method to perform double operations
    public static void PerformDoubleOperations()
    {
        // Taking user input for a, b, and c
        Console.Write("Enter value for a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter value for b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value for c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Performing the operations considering operator precedence
        double result1 = a + b * c;  // a + (b * c)
        double result2 = a * b + c;  // (a * b) + c
        double result3 = c + a / b;  // c + (a / b)
        double result4 = a % b + c;  // (a % b) + c (Note: % doesn't work with doubles, so skipping)

        // Displaying the results
        Console.WriteLine(string.Format(
            "The results of Double Operations are {0}, {1}, and {2}.", 
            result1, result2, result3));
    }
}
