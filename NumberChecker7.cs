using System;

class NumberChecker
{
    // Method to check prime number
    public static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    // Method to check if Neon number (sum of digits of number^2 == number)
    public static bool IsNeonNumber(int number)
    {
        int square = number * number;
        int sumOfDigits = 0;
        while (square > 0)
        {
            sumOfDigits += square % 10;
            square /= 10;
        }
        return sumOfDigits == number;
    }

    // Method to check Spy number (sum of digits == product of digits)
    public static bool IsSpyNumber(int num)
    {
        int sum = 0;
        int product = 1;
        while (num > 0)
        {
            int digit = num % 10;
            sum += digit;
            product *= digit;
            num /= 10;
        }
        return sum == product;
    }

    // Method to check Automorphic (last digit of square of number == number)
    public static bool IsAutomorphic(int num)
    {
        int square = num * num;
        int lastDigit = square % 10;
        return lastDigit == num;
    }

    // Method to check Buzz Number (num divisible by 7 or num ends in 7)
    public static bool IsBuzzNumber(int num)
    {
        return num % 7 == 0 || num % 10 == 7;
    }

    static void Main(string[] args)
    {
        // Input from user
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        // Display output using string.Format
        Console.WriteLine(string.Format("Is Prime?: {0}", IsPrime(num)));
        Console.WriteLine(string.Format("Is Neon Number?: {0}", IsNeonNumber(num)));
        Console.WriteLine(string.Format("Is Spy Number?: {0}", IsSpyNumber(num)));
        Console.WriteLine(string.Format("Is Automorphic Number?: {0}", IsAutomorphic(num)));
        Console.WriteLine(string.Format("Is Buzz Number?: {0}", IsBuzzNumber(num)));
    }
}