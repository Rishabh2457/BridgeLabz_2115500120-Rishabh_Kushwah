using System;

class HandshakeCalculator
{
    public static void Main(string[] args)
    {
        CalculateHandshakes();
    }

    // Method to calculate the maximum num of handshakes
    public static void CalculateHandshakes()
    {
        Console.Write("Enter the num of students: ");
        int numOfStudents = Convert.ToInt32(Console.ReadLine());

        // Using the formula for combinations to calculate handshakes
        int handshakes = (numOfStudents * (numOfStudents - 1)) / 2;

        // Displaying the result
        Console.WriteLine(string.Format("The maximum num of handshakes among {0} students is {1}.", numOfStudents, handshakes));
    }
}
