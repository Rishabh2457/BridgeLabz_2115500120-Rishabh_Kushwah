using System;

class Anagram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter String 1: ");
        string str1 = Console.ReadLine();
        Console.WriteLine("Enter String 2: ");
        string str2 = Console.ReadLine();

        if (str1.Length != str2.Length)
        {
            Console.WriteLine("Not Anagram");
            return;
        }

        char[] arr1 = str1.ToCharArray();
        char[] arr2 = str2.ToCharArray();

        // Sorting both arrays manually using Bubble Sort
        BubbleSort(arr1);
        BubbleSort(arr2);

        // Comparing both sorted arrays
        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                Console.WriteLine("Not Anagram");
                return;
            }
        }

        Console.WriteLine("Strings are Anagram");
    }

    static void BubbleSort(char[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    char temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}
