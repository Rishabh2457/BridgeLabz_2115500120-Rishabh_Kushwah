using System;

class TotalIncome
{
    public static void Main(string[] args)
    {
        CalculateTotalIncome();
    }

    // Method to calculate total income
    public static void CalculateTotalIncome()
    {
        // Taking user input for salary
        Console.Write("Enter your salary (INR): ");
        double salary = Convert.ToDouble(Console.ReadLine());

        // Taking user input for bonus
        Console.Write("Enter your bonus (INR): ");
        double bonus = Convert.ToDouble(Console.ReadLine());

        // Calculating total income
        double totalIncome = salary + bonus;

        // Displaying the results
        Console.WriteLine(string.Format(
            "The salary is INR {0} and bonus is INR {1}. Hence, Total Income is INR {2}.", 
            salary, bonus, totalIncome));
    }
}
