using System;

class AbundantNumber
{
    static void Main(string[] args)
    {
        // Step 1: Get the integer input from the user
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Step 2: Initialize the sum variable to store the sum of divisors
        int sum = 0;

        // Step 3: Run a for loop from i = 1 to i < number
        for (int i = 1; i < number; i++)
        {
            // Step 4: Check if number is divisible by i
            if (number % i == 0)
            {
                sum += i;  // Add i to sum if it's a divisor
            }
        }

        // Step 5: Check if the sum of divisors is greater than the number
        if (sum > number)
        {
            // Step 6: Display the result
            Console.WriteLine(string.Format("{0} is an Abundant Number.", number));
        }
        else
        {
            Console.WriteLine(string.Format("{0} is not an Abundant Number.", number));
        }
    }
}
