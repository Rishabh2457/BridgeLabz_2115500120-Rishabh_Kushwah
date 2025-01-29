using System;

class MultiplicationTable
{
    static void Main(string[] args)
    {
        // Get input from the user for the number
        Console.Write("Enter a number to generate its multiplication table: ");
        int number = int.Parse(Console.ReadLine());

        // Define an array to store the results
        int[] multiplicationTable = new int[10];

        // Generate the multiplication table
        for (int i = 1; i <= 10; i++)
        {
            multiplicationTable[i - 1] = number * i;
        }

        // Display the multiplication table
        Console.WriteLine(string.Format("\nMultiplication Table of {0}:",number));
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(string.Format("{0} * {1} = {2}", number, i, multiplicationTable[i - 1]));
        }
    }
}
