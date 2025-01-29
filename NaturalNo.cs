using System;

class NaturalNo
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number: ");
        int num; // Declare the variable here
        
        if (!int.TryParse(Console.ReadLine(), out num) || num <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            return;
        }

        int formulaSum = FormulaSum(num);
        int recursiveSum = RecursiveSum(num);

        Console.WriteLine(string.Format("Sum using FormulaSum: {0}",formulaSum));
        Console.WriteLine(string.Format("Sum using RecursiveSum: {0}",recursiveSum));

        if (formulaSum == recursiveSum)
        {
            Console.WriteLine("The results match! Both methods are correct.");
        }
        else
        {
            Console.WriteLine("The results do not match. Please check the implementation.");
        }
    }

    static int RecursiveSum(int num)
    {
        if (num == 1)
        {
            return num; // Base case
        }
        return RecursiveSum(num - 1) + num; // Recursive call
    }

    static int FormulaSum(int num)
    {
        return num * (num + 1) / 2; // Using the formula
    }
}
