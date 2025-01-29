using System;

public class NumAnalyzer
{
    // Method to check whether a num is positive or negative
    public static bool IsPositive(int num)
    {
        return num >= 0;
    }

    // Method to check whether a num is even or odd
    public static bool IsEven(int num)
    {
        return num % 2 == 0;
    }

    // Method to compare two nums
    public static int Compare(int num1, int num2)
    {
        if (num1 > num2)
            return 1;
        else if (num1 == num2)
            return 0;
        else
            return -1;
    }

    public static void Main(string[] args)
    {
        int[] nums = new int[5];

        // Take user input for 5 nums
        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write(string.Format("Enter num {0}: ", i + 1));
            nums[i] = int.Parse(Console.ReadLine());
        }

        // Loop through the array and analyze each num
        for (int i = 0; i < nums.Length; i++)
        {
            if (IsPositive(nums[i]))
            {
                Console.Write(string.Format("num {0} is positive and ", nums[i]));
                Console.WriteLine(IsEven(nums[i]) ? "even." : "odd.");
            }
            else
            {
                Console.WriteLine(string.Format("num {0} is negative.", nums[i]));
            }
        }

        // Compare the first and last elements of the array
        int comparisonResult = Compare(nums[0], nums[nums.Length - 1]);
        if (comparisonResult == 1)
        {
            Console.WriteLine(string.Format("The first num ({0}) is greater than the last num ({1}).", nums[0], nums[nums.Length - 1]));
        }
        else if (comparisonResult == 0)
        {
            Console.WriteLine(string.Format("The first num ({0}) is equal to the last num ({1}).", nums[0], nums[nums.Length - 1]));
        }
        else
        {
            Console.WriteLine(string.Format("The first num ({0}) is less than the last num ({1}).", nums[0], nums[nums.Length - 1]));
        }
    }
}
