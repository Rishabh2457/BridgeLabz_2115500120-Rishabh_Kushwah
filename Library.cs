using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Library
{
    public static string LibraryName = "CITY Library";

    public static void DisplayLibraryName()
    {
        Console.WriteLine("This is Library name : " + LibraryName);
    }
    public string Title;
    public string Author;
    public readonly string ISBN;
    public Library(string Title,string Author,string ISBN)
    {
        this.Title = Title;
        this.Author = Author;
        this.ISBN = ISBN;

    }

    public void DisplayDetails()
    {
        if(this is Library)
        {
            Console.WriteLine(Title);
            Console.WriteLine(Author);
            Console.WriteLine(ISBN);
        }
        else
        {
            Console.WriteLine("enter valid detail in format");
        }
    }
}
//class Program
//{
//    public static void Main(string[]   args)
//    {
//        Library obj1 = new Library("blah blah", "Rishabh", "2014");
//        Library obj2 = new Library("awww awww", "Kashish", "40112");
//        Library obj3 = new Library("bhaaaain bhaain", "Akshata", "2410");

//        obj1.DisplayDetails();
//        obj2.DisplayDetails();
//        obj3.DisplayDetails();

//        Library.DisplayLibraryName();
//    }
//}
