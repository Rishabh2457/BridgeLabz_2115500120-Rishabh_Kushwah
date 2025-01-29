
using System;

class ReverseString
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string: ");
        string s1 = Console.ReadLine();

        string reverseString = Reverse(s1);
        Console.WriteLine("Reversed String: " + reverseString);
    }

    static string Reverse(string str)
    {
        char[] charArray = new char[str.Length];
        int j = str.Length - 1;

        for (int i = 0; i < str.Length; i++)
        {
            charArray[i] = str[j];
            j--;
        }

        return new string(charArray);
    }
}
