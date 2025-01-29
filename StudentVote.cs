using System;

public class StudentVoteChecker
{
    // Method to check if a student can vote
    public bool CanStudentVote(int age)
    {
        if (age < 0)
        {
            return false; // Invalid age
        }
        return age >= 18; // Return true if age is 18 or above
    }

    public static void Main(string[] args)
    {
        StudentVoteChecker checker = new StudentVoteChecker();
        int[] studentAges = new int[10]; // Array for 10 students' ages

        // Loop to take user input and check if students can vote
        for (int i = 0; i < studentAges.Length; i++)
        {
            Console.Write(string.Format("Enter age of student {0}: ", i + 1));
            studentAges[i] = int.Parse(Console.ReadLine());

            // Check if the student can vote
            bool canVote = checker.CanStudentVote(studentAges[i]);
            string result = studentAges[i] < 0 
                ? "Invalid age entered. Cannot vote." 
                : string.Format("Student {0} {1}.", i + 1, canVote ? "can vote" : "cannot vote");

            Console.WriteLine(result);
        }
    }
}
