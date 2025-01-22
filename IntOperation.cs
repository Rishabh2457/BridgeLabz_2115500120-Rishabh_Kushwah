using System;

class IntOperation
{
    public static void Main(string[] args)
    {
        PerformOperations();
    }

    // Method to perform integer operations
    public static void PerformOperations()
    {
        // Taking user input for a, b, and c
        Console.Write("Enter value for a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter value for b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter value for c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        // Performing the operations considering operator precedence
        int result1 = a + b * c;  // a + (b * c)
        int result2 = a * b + c;  // (a * b) + c
        int result3 = c + a / b;  // c + (a / b)
        int result4 = a % b + c;  // (a % b) + c

        // Displaying the results
        Console.WriteLine(string.Format(
            "The results of Int Operations are {0}, {1}, {2}, and {3}.", 
            result1, result2, result3, result4));
    }
}
