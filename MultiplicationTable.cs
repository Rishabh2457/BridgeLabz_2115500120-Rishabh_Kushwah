using System;

class MultiplicationTable
{
    public static void Main(string[] args)
    {
        GenerateMultiplicationTable();
    }

    // Method to generate the multiplication table
    public static void GenerateMultiplicationTable()
    {
        Console.Write("Enter a number to generate its multiplication table: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(string.Format("Multiplication Table of {0} from 6 to 9:",number));

        // Loop to iterate from 6 to 9
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine(string.Format("{0} * {1} = {2}", number, i, number * i));
        }
    }
}
