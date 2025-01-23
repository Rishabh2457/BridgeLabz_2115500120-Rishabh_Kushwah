using System;

class FindFactors
{
    static void Main(string[] args)
    {
        // Input number from the user
        Console.Write("Enter a number to find its factors: ");
        int number = int.Parse(Console.ReadLine());

        // Find and display the factors
        Console.WriteLine(string.Format("The factors of {0} are:",number));

        for (int i = 1; i < number; i++)
        {
            if (number % i == 0) // Check if i is a factor of number
            {
                Console.WriteLine(i); // Print the factor
            }
        }
    }
}
