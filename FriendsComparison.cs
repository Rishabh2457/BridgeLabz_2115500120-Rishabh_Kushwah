using System;

public class FriendsComparison
{
    // Method to find the youngest friend
    public static string FindYoungest(string[] names, int[] ages)
    {
        int minAge = 0;
        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < ages[minAge])
            {
                minAge = i;
            }
        }
        return names[minAge];
    }

    // Method to find the tallest friend
    public static string FindTallest(string[] names, double[] heights)
    {
        int maxHeight= 0;
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > heights[maxHeight])
            {
                maxHeight = i;
            }
        }
        return names[maxHeight];
    }

    public static void Main(string[] args)
    {
        string[] friends = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];

        // Taking input for ages and heights
        for (int i = 0; i < friends.Length; i++)
        {
            Console.Write(string.Format("Enter the age of {0}: ",friends[i]));
            ages[i] = int.Parse(Console.ReadLine());
            Console.Write(string.Format("Enter the height of {0} (in meters): ",friends[i]));
            heights[i] = double.Parse(Console.ReadLine());
        }

        // Finding the youngest and tallest friend
        string youngest = FindYoungest(friends, ages);
        string tallest = FindTallest(friends, heights);

        // Displaying the results
        Console.WriteLine(string.Format("\nThe youngest friend is {0}.",youngest));
        Console.WriteLine(string.Format("The tallest friend is {0}.",tallest));
    }
}
