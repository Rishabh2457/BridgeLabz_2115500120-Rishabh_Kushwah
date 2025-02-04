using System;

// Defining a class Student
public class Student
{
    // Protected fields, accessible in derived classes
    protected int rollNumber;
    protected string name;
    private double CGPA;

    // Constructor
    public Student(int rollNumber, string name, double CGPA)
    {
        this.rollNumber = rollNumber;
        this.name = name;
        this.CGPA = CGPA;
    }

    // Method to get the CGPA
    public double GetCGPA()
    {
        return CGPA;
    }

    // Method to set the CGPA
    public void SetCGPA(double CGPA)
    {
        if (CGPA >= 0.0 && CGPA <= 4.0)
        {
            this.CGPA = CGPA;
        }
        else
        {
            Console.WriteLine("Invalid CGPA");
        }
    }
}

// PostgraduateStudent class inherits from Student
public class PostgraduateStudent : Student
{
    public string researchTopic;

    // Constructor
    public PostgraduateStudent(int rollNumber, string name, double CGPA, string researchTopic)
        : base(rollNumber, name, CGPA)
    {
        this.researchTopic = researchTopic;
    }

    // Method to display the student information
    public void DisplayStudentInfo()
    {
        Console.WriteLine(string.Format("Roll Number: {0}", rollNumber));
        Console.WriteLine(string.Format("Name: {0}", name));
        Console.WriteLine(string.Format("CGPA: {0}", GetCGPA()));
        Console.WriteLine(string.Format("Research Topic: {0}", researchTopic));
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of PostgraduateStudent
        PostgraduateStudent pgStudent = new PostgraduateStudent(21, "Rishabh Kushwah", 3.9, "Artificial Intelligence");
        pgStudent.DisplayStudentInfo();
    }
}
