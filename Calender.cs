using System;

class Calendar
{
    // Method to get name of the month
    public static string GetMonthName(int month)
    {
        string[] months = {
            "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"
        };
        return months[month - 1];
    }

    // Check for leap year
    public static bool LeapYear(int year)
    {
        return ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0);
    }

    // Method to get days in month
    public static int GetDaysInMonth(int month, int year)
    {
        int[] days = { 31, 28, 31, 30, 31, 30, 31, 30, 31, 30, 31, 30 };
        if (LeapYear(year) && month == 2)
        {
            days[1] = 29;
        }
        return days[month - 1];
    }

    // Method to get first day of the month
    public static int GetFirstDayOfMonth(int year, int month)
    {
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        int d0 = (1 + x + 31 * m0 / 12) % 7;
        return d0;
    }

    // Method to display calendar
    public static void DisplayCalendar(int month, int year)
    {
        Console.WriteLine(string.Format("  {0} {1}", GetMonthName(month), year));
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        int daysInMonth = GetDaysInMonth(month, year);
        int firstDay = GetFirstDayOfMonth(year, month);

        // First loop for indentation
        for (int i = 0; i < firstDay; i++)
        {
            Console.Write("    ");
        }

        // Second loop to display the days
        for (int day = 1; day <= daysInMonth; day++)
        {
            Console.Write(string.Format("{0,3} ", day));
            // Move to the next line after Saturday
            if ((day + firstDay) % 7 == 0)
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine(); // Final newline
    }

    static void Main(string[] args)
    {
        // Input from user
        Console.Write("Enter month (1-12): ");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        // Call the DisplayCalendar method
        DisplayCalendar(month, year);
    }
}



