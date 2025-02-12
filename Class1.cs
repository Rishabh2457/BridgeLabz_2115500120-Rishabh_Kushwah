using System;

class StudentNode
{
    public int RollNumber;
    public string Name;
    public int Age;
    public char Grade;
    public StudentNode Next;

    public StudentNode(int roll, string name, int age, char grade)
    {
        RollNumber = roll;
        Name = name;
        Age = age;
        Grade = grade;
        Next = null;
    }
}

class StudentLinkedList
{
    private StudentNode head;

    // Add Student at the Beginning
    public void AddAtBeginning(int roll, string name, int age, char grade)
    {
        StudentNode newNode = new StudentNode(roll, name, age, grade);
        newNode.Next = head;
        head = newNode;
    }

    // Add Student at the End
    public void AddAtEnd(int roll, string name, int age, char grade)
    {
        StudentNode newNode = new StudentNode(roll, name, age, grade);
        if (head == null)
        {
            head = newNode;
            return;
        }

        StudentNode temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newNode;
    }

    // Add Student at Specific Position (1-based index)
    public void AddAtPosition(int roll, string name, int age, char grade, int position)
    {
        StudentNode newNode = new StudentNode(roll, name, age, grade);

        if (position == 1)
        {
            newNode.Next = head;
            head = newNode;
            return;
        }

        StudentNode temp = head;
        int count = 1;

        while (temp != null && count < position - 1)
        {
            temp = temp.Next;
            count++;
        }

        if (temp == null)
        {
            Console.WriteLine("Position out of bounds!");
            return;
        }

        newNode.Next = temp.Next;
        temp.Next = newNode;
    }

    // Delete Student by Roll Number
    public void DeleteStudent(int roll)
    {
        if (head == null) return;

        if (head.RollNumber == roll)
        {
            head = head.Next;
            return;
        }

        StudentNode temp = head;
        while (temp.Next != null && temp.Next.RollNumber != roll)
        {
            temp = temp.Next;
        }

        if (temp.Next == null)
        {
            Console.WriteLine("Student not found!");
            return;
        }

        temp.Next = temp.Next.Next;
    }

    // Search Student by Roll Number
    public void SearchStudent(int roll)
    {
        StudentNode temp = head;
        while (temp != null)
        {
            if (temp.RollNumber == roll)
            {
                Console.WriteLine($"Found: Roll: {temp.RollNumber}, Name: {temp.Name}, Age: {temp.Age}, Grade: {temp.Grade}");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Student not found!");
    }

    // Update Student Grade by Roll Number
    public void UpdateGrade(int roll, char newGrade)
    {
        StudentNode temp = head;
        while (temp != null)
        {
            if (temp.RollNumber == roll)
            {
                temp.Grade = newGrade;
                Console.WriteLine("Grade updated successfully!");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Student not found!");
    }

    // Display All Student Records
    public void DisplayRecords()
    {
        if (head == null)
        {
            Console.WriteLine("No student records found!");
            return;
        }

        StudentNode temp = head;
        while (temp != null)
        {
            Console.WriteLine($"Roll: {temp.RollNumber}, Name: {temp.Name}, Age: {temp.Age}, Grade: {temp.Grade}");
            temp = temp.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        StudentLinkedList studentList = new StudentLinkedList();

        studentList.AddAtEnd(101, "Rishabh", 20, 'A');
        studentList.AddAtEnd(102, "Rishi", 21, 'B');
        studentList.AddAtBeginning(103, "AKSHATA", 22, 'C');
        studentList.AddAtPosition(104, "Rahul", 19, 'B', 2);

        Console.WriteLine("Student Records:");
        studentList.DisplayRecords();
        Console.WriteLine("-----------------------------");

        Console.WriteLine("\nSearching for Roll Number 102:");
        studentList.SearchStudent(102);
        Console.WriteLine("-----------------------------");

        Console.WriteLine("\nDeleting Roll Number 103:");
        studentList.DeleteStudent(103);
        studentList.DisplayRecords();
        Console.WriteLine("-----------------------------");

        Console.WriteLine("\nUpdating Grade for Roll Number 101:");
        studentList.UpdateGrade(101, 'A');
        studentList.DisplayRecords();
        Console.WriteLine("-----------------------------");
    }
}
