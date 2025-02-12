using System;

class Movie
{
    public string Title;
    public string Director;
    public int Year;
    public double Rating;
    public Movie Next;
    public Movie Prev;

    public Movie(string title, string director, int year, double rating)
    {
        Title = title;
        Director = director;
        Year = year;
        Rating = rating;
        Next = Prev = null;
    }
}

class DoublyLinkedList
{
    private Movie head;

    // Add a movie at the beginning
    public void AddAtBeginning(string title, string director, int year, double rating)
    {
        Movie newMovie = new Movie(title, director, year, rating);
        newMovie.Next = head;

        if (head != null)
        {
            head.Prev = newMovie;
        }

        head = newMovie;
    }

    // Add a movie at the end
    public void AddAtEnd(string title, string director, int year, double rating)
    {
        Movie newMovie = new Movie(title, director, year, rating);
        if (head == null)
        {
            head = newMovie;
            return;
        }

        Movie curr = head;
        while (curr.Next != null)
        {
            curr = curr.Next;
        }

        curr.Next = newMovie;
        newMovie.Prev = curr;
    }

    // Remove a movie by title
    public void RemoveMovie(string title)
    {
        Movie curr = head;

        while (curr != null)
        {
            if (curr.Title == title)
            {
                if (curr.Prev != null)
                {
                    curr.Prev.Next = curr.Next;
                }
                else
                {
                    head = curr.Next;
                }

                if (curr.Next != null)
                {
                    curr.Next.Prev = curr.Prev;
                }

                Console.WriteLine($"Movie '{title}' removed.");
                return;
            }
            curr = curr.Next;
        }

        Console.WriteLine($"Movie '{title}' not found.");
    }

    // Search for a movie by director or rating
    public void SearchMovies(string director = null, double? rating = null)
    {
        Movie curr = head;
        bool found = false;

        while (curr != null)
        {
            if ((director != null && curr.Director == director) || (rating != null && curr.Rating == rating))
            {
                Console.WriteLine($"Found Movie: {curr.Title} | Director: {curr.Director} | Year: {curr.Year} | Rating: {curr.Rating}");
                found = true;
            }
            curr = curr.Next;
        }

        if (!found)
        {
            Console.WriteLine("No matching movies found.");
        }
    }

    // Display all movies in forward order
    public void DisplayForward()
    {
        if (head == null)
        {
            Console.WriteLine("No movies to display.");
            return;
        }

        Movie curr = head;
        Console.WriteLine("Movies (Forward Order):");
        while (curr != null)
        {
            Console.WriteLine($"{curr.Title} | Director: {curr.Director} | Year: {curr.Year} | Rating: {curr.Rating}");
            curr = curr.Next;
        }
    }

    // Display all movies in reverse order
    public void DisplayReverse()
    {
        if (head == null)
        {
            Console.WriteLine("No movies to display.");
            return;
        }

        Movie curr = head;
        while (curr.Next != null)
        {
            curr = curr.Next;
        }

        Console.WriteLine("Movies (Reverse Order):");
        while (curr != null)
        {
            Console.WriteLine($"{curr.Title} | Director: {curr.Director} | Year: {curr.Year} | Rating: {curr.Rating}");
            curr = curr.Prev;
        }
    }

    // Update the rating of a movie by title
    public void UpdateRating(string title, double newRating)
    {
        Movie curr = head;

        while (curr != null)
        {
            if (curr.Title == title)
            {
                curr.Rating = newRating;
                Console.WriteLine($"Rating for '{title}' updated to {newRating}.");
                return;
            }
            curr = curr.Next;
        }

        Console.WriteLine($"Movie '{title}' not found.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        DoublyLinkedList movieList = new DoublyLinkedList();

        // Adding movies
        movieList.AddAtEnd("Inception", "Christopher Nolan", 2010, 8.8);
        movieList.AddAtEnd("The Godfather", "Francis Ford Coppola", 1972, 9.2);
        movieList.AddAtBeginning("Pulp Fiction", "Quentin Tarantino", 1994, 8.9);

        // Display movies
        movieList.DisplayForward();
        movieList.DisplayReverse();

        // Search for a movie by director
        movieList.SearchMovies(director: "Christopher Nolan");

        // Update the rating of a movie
        movieList.UpdateRating("Inception", 9.0);

        // Remove a movie
        movieList.RemoveMovie("The Godfather");

        // Display movies after removal
        movieList.DisplayForward();
    }
}
