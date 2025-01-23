using System;

class ArmstrongNumber
{
    static void Main(string[] args)
    {
        // Step 1: Get the input number from the user
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        
        // Step 2: Initialize variables
        int sum = 0;
        int originalNumber = number;

        // Step 3: Use a while loop to process each digit of the number
        while (number != 0)
        {
            // Step 4: Get the last digit using modulus operator
            int digit = number % 10;
            
            // Step 5: Cube the digit and add to sum
            sum += digit * digit * digit;
            
            // Step 6: Remove the last digit from the number
            number /= 10;
        }

        // Step 7: Compare the sum with the original number and display the result using string.Format
        if (sum == originalNumber)
        {
            Console.WriteLine(string.Format("{0} is an Armstrong number.", originalNumber));
        }
        else
        {
            Console.WriteLine(string.Format("{0} is not an Armstrong number.", originalNumber));
        }
    }
}
