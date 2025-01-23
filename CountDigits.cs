using System;

class CountDigits
{
    static void Main(string[] args)
    {
        // Step 1: Get the integer input from the user
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());

        // Step 2: Initialize the count variable
        int count = 0;

        // Step 3: Use a while loop to count the digits
        while (number != 0)
        {
            number /= 10;  // Remove the last digit from the number
            count++;       // Increase the count by 1
        }

        // Step 4: Display the result using string.Format
        Console.WriteLine(string.Format("The number has {0} digits.", count));
    }
}
