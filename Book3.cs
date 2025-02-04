using System;

// Defining a class Book3
public class Book3
{
    private string isbn;
    protected string title;
    private string author;

    // Property for ISBN
    public string ISBN
    {
        get { return isbn; }
        set { isbn = value; }
    }

    // Defining a method to get the author of the book
    public string GetAuthor()
    {
        return author;
    }

    // Defining a method to set the author of the book
    public void SetAuthor(string authorName)
    {
        author = authorName;
    }

    // Method to set the title
    public void SetTitle(string bookTitle)
    {
        title = bookTitle;
    }
}

public class EBook : Book3
{
    // Defining a method to display the book information
    public void DisplayBookInfo()
    {
        Console.WriteLine(string.Format("ISBN: {0}", ISBN));
        Console.WriteLine(string.Format("Title: {0}", title));
    }
}

class Program
{
    static void Main()
    {
        // Creating a Book3 instance and setting its values
        Book3 book3 = new Book3();  // Correct class name here
        book3.ISBN = "123-456-789";
        book3.SetAuthor("Sing Shong");
        book3.SetTitle("C# Programming");  // Set the title for Book3

        // Creating an EBook instance and displaying its information
        EBook ebook = new EBook();
        ebook.ISBN = "987-654-321";
        ebook.SetTitle("Advanced C# Programming");  // Set the title for EBook
        ebook.DisplayBookInfo();
    }
}
