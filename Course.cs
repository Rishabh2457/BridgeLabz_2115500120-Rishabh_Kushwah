using System;

class Course
{
    // Instance variables
    private string courseName;
    private int duration;
    private double fee;

    // Class variable (Static)
    private static string instituteName = "Default Institute";

    // Constructor
    public Course(string courseName, int duration, double fee)
    {
        this.courseName = courseName;
        this.duration = duration;
        this.fee = fee;
    }

    // Instance method to display course details
    public void DisplayCourseDetails()
    {
        Console.WriteLine(string.Format("Course Name: {0}", courseName));
        Console.WriteLine(string.Format("Duration: {0} hours", duration));
        Console.WriteLine(string.Format("Fee: ${0:F2}", fee));
        Console.WriteLine(string.Format("Institute Name: {0}", instituteName));
    }

    // Class method to update institute name
    public static void UpdateInstituteName(string newInstituteName)
    {
        instituteName = newInstituteName;
    }

    // Main method for testing
    static void Main(string[] args)
    {
        // Update institute name
        Course.UpdateInstituteName("Tech Institute");

        // Create course instances
        Course course1 = new Course("C# Programming", 30, 300);
        Course course2 = new Course("Java Programming", 40, 400);

        // Display course details
        course1.DisplayCourseDetails();
        Console.WriteLine();
        course2.DisplayCourseDetails();
    }
}
