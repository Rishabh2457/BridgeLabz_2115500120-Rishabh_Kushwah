using System;

class LeapYearChecker
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a year (>= 1582): ");
        int year = Convert.ToInt32(Console.ReadLine());

        // Approach 1: Using multiple if-else statements
        if (year < 1582)
        {
            Console.WriteLine(string.Format("Invalid input! Please enter a year >= 1582."));
        }
        else if (year % 4 != 0)
        {
            Console.WriteLine(string.Format("{0} is not a Leap Year.", year));
        }
        else if (year % 100 == 0 && year % 400 != 0)
        {
            Console.WriteLine(string.Format("{0} is not a Leap Year.", year));
        }
        else
        {
            Console.WriteLine(string.Format("{0} is a Leap Year.", year));
        }

        // Approach 2: Using a single if statement with multiple logical operators
        CheckLeapYearWithLogical(year);
    }

    // Method to use a single if statement with multiple logical operators
    public static void CheckLeapYearWithLogical(int year)
    {
        if (year >= 1582 && ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)))
        {
            Console.WriteLine(string.Format("{0} is a Leap Year.", year));
        }
        else if (year < 1582)
        {
            Console.WriteLine(string.Format("Invalid input! Please enter a year >= 1582."));
        }
        else
        {
            Console.WriteLine(string.Format("{0} is not a Leap Year.", year));
        }
    }
}
