using System;

class HandShakes
{
    // Method to calculate the number of handshakes among students
    public static int CalculateHandshakes(int hands)
    {
        return (hands * (hands - 1)) / 2;
    }

    static void Main(string[] args)
    {
        // Input from user
        Console.Write("Enter the number of students: ");
        int students = Convert.ToInt32(Console.ReadLine());
        
        // Call the method
        int handshakes = CalculateHandshakes(students);
        
        // Display the output using string.Format
        Console.WriteLine(string.Format("The number of handshakes among {0} students is: {1}", students, handshakes));
    }
}
