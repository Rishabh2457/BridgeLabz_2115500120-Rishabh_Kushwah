using System;

class HarshadNumber
{
    static void Main(string[] args)
    {
        // Step 1: Get the integer input from the user
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Step 2: Initialize the sum variable
        int sum = 0;
        int originalNumber = number;

        // Step 3: Use a while loop to find the sum of digits
        while (number != 0)
        {
            sum += number % 10;  // Add the last digit to sum
            number /= 10;         // Remove the last digit
        }

        // Step 4: Check if the number is divisible by the sum of its digits
        if (originalNumber % sum == 0)
        {
            // Step 5: Display the result
            Console.WriteLine(string.Format("{0} is a Harshad Number.", originalNumber));
        }
        else
        {
            Console.WriteLine(string.Format("{0} is not a Harshad Number.", originalNumber));
        }
    }
}
