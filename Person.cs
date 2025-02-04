using System;

// Defining a class Person
class Person
{
    private string name;
    private int age;
    private int height;
    private int weight;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public int Height
    {
        get { return height; }
        set { height = value; }
    }

    public int Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    // Parameterized Constructor
    public Person(string name, int age, int height, int weight)
    {
        Name = name;
        Age = age;
        Height = height;
        Weight = weight;
    }

    // Copy Constructor
    public Person(Person person)
    {
        Name = person.Name;
        Age = person.Age;
        Height = person.Height;
        Weight = person.Weight;
    }

    // Method to display the details of the person
    public void Display()
    {
        Console.WriteLine(string.Format("Name: {0}", Name));
        Console.WriteLine(string.Format("Age: {0}", Age));
        Console.WriteLine(string.Format("Height: {0}", Height));
        Console.WriteLine(string.Format("Weight: {0}", Weight));
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person("Rishabh", 21, 166, 55); // Using Parameterized Constructor
        Person p2 = new Person(p1); // Using Copy Constructor
        
        Console.WriteLine("Person 1 Details:");
        p1.Display();

        Console.WriteLine("\nPerson 2 Details (Copied):");
        p2.Display();
    }
}
