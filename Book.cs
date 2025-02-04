using System;

//Book Class
class Book
{
    private string title;
    private string author;
    private int price;

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public int Price
    {
        get { return price; }
        private set { price = value; }
    }

    //Default Constructor
    public Book()
    {
        Title = "Unknown";
        Author = "Unknown";
        Price = FindPrice();
    }

    //Parameterized Constructor
    public Book(string title, string author)
    {
        Title = title;
        Author = author;
        Price = FindPrice();
    }

    //Find Price
    private int FindPrice()
    {
        switch (title.ToLower())
        {
            case "book1": return 100;
            case "book2": return 200;
            case "book3": return 300;
            default: return 1000;
        }
    }

    //Display Book Details
    public void Display()
    {
        Console.WriteLine(string.Format("Title: {0}", Title));
        Console.WriteLine(string.Format("Author: {0}", Author));
        Console.WriteLine(string.Format("Price: {0}", Price));
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book b1 = new Book(); // Uses default constructor
        b1.Display();

        Book b2 = new Book("Book2", "Author2"); // Uses parameterized constructor
        b2.Display();
    }
}
