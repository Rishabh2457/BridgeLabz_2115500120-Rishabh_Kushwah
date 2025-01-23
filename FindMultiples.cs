using System;

class FindMultiples
{
    static void Main(string[] args)
    {
        // Input number from the user
        Console.Write("Enter a number to find its multiples below 100: ");
        int number = int.Parse(Console.ReadLine());

        // Find and display the multiples of the number
        Console.WriteLine(string.Format("The multiples of {0} below 100 are:",number));

        for (int i = 100; i >= 1; i--)
        {
            if (i % number == 0) // Check if i is a multiple of the number
            {
                Console.WriteLine(i); // Print the multiple
            }
        }
    }
}
