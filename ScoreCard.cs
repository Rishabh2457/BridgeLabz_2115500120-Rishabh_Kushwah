using System;

class ScoreCard
{
    // Method to generate random 2-digit scores for PCM
    public static int[,] GenerateScores(int numStudents)
    {
        Random random = new Random();
        int[,] scores = new int[numStudents, 3];
        for (int i = 0; i < numStudents; i++)
        {
            scores[i, 0] = random.Next(10, 100); // Physics
            scores[i, 1] = random.Next(10, 100); // Chemistry
            scores[i, 2] = random.Next(10, 100); // Maths
        }
        return scores;
    }

    // Method to calculate total, average, and percentage for each student
    public static double[,] CalculateResults(int[,] scores, int numStudents)
    {
        double[,] results = new double[numStudents, 3];
        for (int i = 0; i < numStudents; i++)
        {
            int total = scores[i, 0] + scores[i, 1] + scores[i, 2];
            // Calculate average and percentage
            double average = total / 3.0;
            double percentage = (total / 300.0) * 100;
            // Store results rounded to 2 decimal places
            results[i, 0] = total;
            results[i, 1] = Math.Round(average, 2);
            results[i, 2] = Math.Round(percentage, 2);
        }
        return results;
    }

    // Method to display the scorecard in a tabular format
    public static void DisplayScoreCard(int[,] scores, double[,] results, int numStudents)
    {
        Console.WriteLine("Student\tPhysics\tChemistry\tMaths\tTotal\tAverage\tPercentage");
        for (int i = 0; i < numStudents; i++)
        {
            Console.Write(string.Format("{0}\t{1}\t{2}\t\t{3}\t", i + 1, scores[i, 0], scores[i, 1], scores[i, 2]));
            Console.WriteLine(string.Format("{0}\t{1}\t{2}%", results[i, 0], results[i, 1], results[i, 2]));
        }
    }

    static void Main(string[] args)
    {
        // Input from user
        Console.Write("Enter the number of students: ");
        int numStudents = Convert.ToInt32(Console.ReadLine());
        // Generate scores for students
        int[,] scores = GenerateScores(numStudents);
        // Calculate result
        double[,] results = CalculateResults(scores, numStudents);
        // Display result
        DisplayScoreCard(scores, results, numStudents);
    }
}
