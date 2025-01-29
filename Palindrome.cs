using System;

class Palindrome
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string: ");
        string s1 = Console.ReadLine();

        if (IsPalindrome(s1))
        {
            Console.WriteLine("The string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The string is not a palindrome.");
        }
    }

    static bool IsPalindrome(string str)
    {
        int start = 0;
        int end = str.Length - 1;

        while (start < end)
        {
            if (str[start] != str[end])
            {
                return false;
            }
            start++;
            end--;
        }
        return true;
    }
}
