using System;

class PositiveNegative
{
    // Method to check if number is positive, negative, or zero
    public static int Check(double number)
    {
        if (number > 0)
        {
            return 1;
        }
        else if (number < 0)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }

    static void Main(string[] args)
    {
        // Input from user
        Console.Write("Enter the number: ");
        double number = Convert.ToDouble(Console.ReadLine());
        
        // Call the method
        int result = Check(number);
        
        // Display the output using string.Format
        if (result == 1)
        {
            Console.WriteLine(string.Format("The number is Positive"));
        }
        else if (result == -1)
        {
            Console.WriteLine(string.Format("The number is Negative"));
        }
        else
        {
            Console.WriteLine(string.Format("The number is Zero"));
        }
    }
}
