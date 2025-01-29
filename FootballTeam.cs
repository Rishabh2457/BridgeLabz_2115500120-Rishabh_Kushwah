using System;

public class FootballTeam
{
    // Method to generate random heights for the players
    public static int[] GenerateRandomHeights(int size, int minHeight, int maxHeight)
    {
        Random random = new Random();
        int[] heights = new int[size];
        
        for (int i = 0; i < size; i++)
        {
            heights[i] = random.Next(minHeight, maxHeight + 1); // Generate random height between minHeight and maxHeight
        }
        
        return heights;
    }

    // Method to find the sum of all elements in the array
    public static int FindSum(int[] heights)
    {
        int sum = 0;
        foreach (int height in heights)
        {
            sum += height;
        }
        return sum;
    }

    // Method to find the mean height
    public static double FindMeanHeight(int[] heights)
    {
        int sum = FindSum(heights);
        return sum / (double)heights.Length;
    }

    // Method to find the shortest height
    public static int FindShortestHeight(int[] heights)
    {
        int shortest = heights[0];
        foreach (int height in heights)
        {
            if (height < shortest)
            {
                shortest = height;
            }
        }
        return shortest;
    }

    // Method to find the tallest height
    public static int FindTallestHeight(int[] heights)
    {
        int tallest = heights[0];
        foreach (int height in heights)
        {
            if (height > tallest)
            {
                tallest = height;
            }
        }
        return tallest;
    }

    public static void Main(string[] args)
    {
        // Size of the football team
        int teamSize = 11;
        int minHeight = 150; // Minimum height (cm)
        int maxHeight = 250; // Maximum height (cm)

        // Generate random heights for the players
        int[] heights = GenerateRandomHeights(teamSize, minHeight, maxHeight);

        // Find the required values
        int sum = FindSum(heights);
        double meanHeight = FindMeanHeight(heights);
        int shortestHeight = FindShortestHeight(heights);
        int tallestHeight = FindTallestHeight(heights);

        // Display the results
        Console.WriteLine("Football Team Heights (in cms):");
        foreach (int height in heights)
        {
            Console.Write(height + " ");
        }

        Console.WriteLine("\n\nResults:");
        Console.WriteLine(string.Format("Shortest Height: {0} cms", shortestHeight));
        Console.WriteLine(string.Format("Tallest Height: {0} cms", tallestHeight));
        Console.WriteLine(string.Format("Mean Height: {0:F2} cms", meanHeight));
    }
}
