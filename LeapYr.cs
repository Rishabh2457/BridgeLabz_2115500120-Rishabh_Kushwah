using System;

class LeapYearChecker
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a year (>= 1582): ");
        int year;

        
            year = Convert.ToInt32(Console.ReadLine());

            if (year < 1582)
            {
                Console.WriteLine("The Leap Year program only works for years >= 1582.");
                return;
            }

            if (IsLeapYear(year))
            {
                Console.WriteLine(string.Format("{0} is a Leap Year.",year));
            }
            else
            {
                Console.WriteLine(string.Format("{0} is not a Leap Year.",year));
            }
       
    }

    // Method to check for a Leap Year
    static bool IsLeapYear(int year)
    {
        // A leap year is divisible by 4 and not divisible by 100, 
        // or divisible by 400
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}
