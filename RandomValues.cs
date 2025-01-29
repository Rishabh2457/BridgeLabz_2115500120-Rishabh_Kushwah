using System;

public class RandomValues
{
    // Method to generate an array of 4-digit random numbers
    public static int[] Generate4DigitRandomArray(int size)
    {
        Random random = new Random();
        int[] numbers = new int[size];
        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(1000, 10000); // Generates a 4-digit random number
        }
        return numbers;
    }

    // Method to find the average, min, and max value of an array
    public static double[] FindAverageMinMax(int[] numbers)
    {
        double sum = 0;
        int min = numbers[0];
        int max = numbers[0];

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
            min = Math.Min(min, numbers[i]);
            max = Math.Max(max, numbers[i]);
        }

        double average = sum / numbers.Length;
        return new double[] { average, min, max };
    }

    public static void Main(string[] args)
    {
        // Generate 5 random 4-digit numbers
        int[] randomNumbers = Generate4DigitRandomArray(5);

        // Find the average, min, and max values
        double[] results = FindAverageMinMax(randomNumbers);

        // Display the results
        Console.WriteLine("Generated 4-digit numbers: ");
        for (int i = 0; i < randomNumbers.Length; i++)
        {
            Console.WriteLine(randomNumbers[i]);
        }

        Console.WriteLine(string.Format("Average: {0:F2}", results[0]));
        Console.WriteLine(string.Format("Minimum: {0}", results[1]));
        Console.WriteLine(string.Format("Maximum: {0}", results[2]));
    }
}
