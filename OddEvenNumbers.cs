using System;

class OddEvenNumbers
{
    public static void Main(string[] args)
    {
        PrintOddEvenNumbers();
    }

    // Method to print odd and even numbers
    public static void PrintOddEvenNumbers()
    {
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the input is a positive integer
        if (number <= 0)
        {
            Console.WriteLine("Please enter a positive integer greater than 0.");
            return;
        }

        // Loop to iterate from 1 to the entered number
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(string.Format("{0} is an even number.", i));
            }
            else
            {
                Console.WriteLine(string.Format("{0} is an odd number.", i));
            }
        }
    }
}
