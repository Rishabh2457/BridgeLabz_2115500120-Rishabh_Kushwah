using System;

// Create a class named Book
public class Book
{
    private string title;
    private string author;
    private int price;
    private bool isAvailable;

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
        set { price = value; }
    }

    public bool IsAvailable
    {
        get { return isAvailable; }
        private set { isAvailable = value; }
    }

    // Parameterized constructor (C# 2005 does NOT support optional parameters)
    public Book(string title, string author, int price, bool isAvailable)
    {
        Title = title;
        Author = author;
        Price = price;
        IsAvailable = isAvailable;
    }

    // Overloaded constructor (C# 2005 does NOT support constructor chaining)
    public Book(string title, string author, int price)
    {
        Title = title;
        Author = author;
        Price = price;
        IsAvailable = true; // Default availability
    }

    // Method to borrow a book
    public bool BorrowBook()
    {
        if (IsAvailable)
        {
            IsAvailable = false;
            Console.WriteLine(string.Format("You have successfully borrowed '{0}' by {1}.", Title, Author));
            return true;
        }
        else
        {
            Console.WriteLine(string.Format("Sorry, '{0}' by {1} is currently unavailable.", Title, Author));
            return false;
        }
    }

    // Method to return a book
    public void ReturnBook()
    {
        if (!IsAvailable)
        {
            IsAvailable = true;
            Console.WriteLine(string.Format("You have successfully returned '{0}'.", Title));
        }
        else
        {
            Console.WriteLine(string.Format("'{0}' was not borrowed.", Title));
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating book instances
        Book book1 = new Book("ORV", "Sing Shong", 1100);
        book1.BorrowBook(); // Should succeed
        book1.BorrowBook(); // Should fail (already borrowed)
        Console.WriteLine();

        book1.ReturnBook(); // Should succeed
        book1.ReturnBook(); // Should fail (already returned)
        Console.WriteLine();

        // Creating a book that is already unavailable
        Book book2 = new Book("ORV", "Sing Shong", 1100, false);
        book2.BorrowBook(); // Should fail
    }
}
