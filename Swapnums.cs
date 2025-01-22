using System;

class Swapnums
{
    public static void Main(string[] args)
    {
        SwapTwonums();
    }

    // Method to swap two nums
    public static void SwapTwonums()
    {
        // Taking user input for num1
        Console.Write("Enter the first num: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        // Taking user input for num2
        Console.Write("Enter the second num: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Swapping the nums
        int temp = num1;
        num1 = num2;
        num2 = temp;

        // Displaying the swapped nums
        Console.WriteLine(string.Format("The swapped numbers are {0} and {1}.",num1, num2));
    }
}
