using System;

class EmployeeBonusCalculator
{
    public static void Main(string[] args)
    {
        CalculateBonus();
    }

    // Method to calculate bonus
    public static void CalculateBonus()
    {
        Console.Write("Enter the employee's salary (INR): ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the employee's years of service: ");
        int yearsOfService = Convert.ToInt32(Console.ReadLine());

        // Check if the years of service are more than 5 years
        if (yearsOfService > 5)
        {
            double bonus = salary * 0.05; // 5% bonus
            Console.WriteLine(string.Format("The bonus amount is INR {0}.", bonus));
        }
        else
        {
            Console.WriteLine("The employee is not eligible for a bonus.");
        }
    }
}
