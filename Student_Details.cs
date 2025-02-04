using System;

class Student
{
    // Static variable shared by all students
    public static string UniversityName = "ABC University";
    
    // Static variable to track the number of students
    private static int totalStudents = 0;
    
    // Instance variables
    public string Name;
    public readonly int RollNumber;
    public string Grade;

    // Constructor using 'this' keyword
    public Student(string Name, int RollNumber, string Grade)
    {
        this.Name = Name;
        this.RollNumber = RollNumber;
        this.Grade = Grade;
        
        // Increment the total students count
        totalStudents++;
    }

    // Static method to display the total number of students
    public static void DisplayTotalStudents()
    {
        Console.WriteLine("Total Students Enrolled: " + totalStudents);
    }

    // Method to display student details (without using object parameter)
    public void DisplayDetails()
    {
        // Using 'is' operator to check if 'this' is an instance of Student (always true)
        if (this is Student)
        {
            Console.WriteLine("University Name: " + UniversityName);
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Roll Number: " + RollNumber);
            Console.WriteLine("Grade: " + Grade);
        }
        else
        {
            Console.WriteLine("Invalid Student Data.");
        }
    }

    // Method to update grade
    public void UpdateGrade(string newGrade)
    {
        this.Grade = newGrade;
        Console.WriteLine(string.Format("Grade updated successfully for {0} (Roll No: {1}).",Name,RollNumber));
    }
}

class Program
{
    public static void Main(string[] args)
    {
        // Creating Student objects
        Student s1 = new Student("Rishabh", 101, "A");
        Student s2 = new Student("Amit", 102, "B");

        // Displaying details
        s1.DisplayDetails();
        s2.DisplayDetails();

        // Updating a student's grade
        s1.UpdateGrade("A+");

        // Displaying updated details
        s1.DisplayDetails();

        // Displaying total number of students
        Student.DisplayTotalStudents();
    }
}
