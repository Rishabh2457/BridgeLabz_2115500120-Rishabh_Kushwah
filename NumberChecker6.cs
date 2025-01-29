using System;

class NumberChecker6
{
    // Method to find the count of digits 
    public static int CountDigits(int num)
    {
        int count = 0;
        // Loop to count digits
        while (num != 0)
        {
            count++;
            num /= 10;
        }
        return count;
    }

    // Method to store the digits of number in a digits array
    public static int[] StoreDigits(int num)
    {
        int count = CountDigits(num);
        int[] digits = new int[count];
        int index = count - 1;
        // Loop to store digits
        while (num != 0)
        {
            digits[index] = num % 10;
            num /= 10;
            index--;
        }
        return digits;
    }

    // Method to reverse the digits array
    public static int[] ReverseDigits(int[] digits)
    {
        int[] reversed = new int[digits.Length];
        for (int i = 0, j = digits.Length - 1; i < digits.Length; i++, j--)
        {
            reversed[i] = digits[j];
        }
        return reversed;
    }

    // Method to compare two arrays and check if they are equal
    public static bool AreArraysEqual(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length)
        {
            return false;
        }
        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                return false;
            }
        }
        return true;
    }

    // Method to check if a number is a palindrome
    public static bool IsPalindrome(int[] digits)
    {
        int[] reversedDigits = ReverseDigits(digits);
        return AreArraysEqual(digits, reversedDigits);
    }

    // Check for duck number (it does not have zeros)
    public static bool IsDuckNumber(int[] digits)
    {
        for (int i = 1; i < digits.Length; i++)
        {
            if (digits[i] == 0)
            {
                return true;
            }
        }
        return false;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        // Call methods and display results
        int[] digits = StoreDigits(num);

        // Display output
        Console.WriteLine(string.Format("Count of digits: {0}", CountDigits(num)));

        // Print digits
        Console.Write("Digits: ");
        for (int i = 0; i < digits.Length; i++)
        {
            Console.Write(string.Format("{0}, ", digits[i]));
        }
        Console.WriteLine();

        // Call the method to reverse digits
        int[] reverseDigits = ReverseDigits(digits);
        Console.Write("Reverse Digits: ");
        for (int i = 0; i < reverseDigits.Length; i++)
        {
            Console.Write(string.Format("{0}, ", reverseDigits[i]));
        }
        Console.WriteLine();

        // Call method to check palindrome
        Console.WriteLine(string.Format("Is Palindrome: {0}", IsPalindrome(digits)));

        // Call method to check duck number
        Console.WriteLine(string.Format("Is Duck Number: {0}", IsDuckNumber(digits)));
    }
}
