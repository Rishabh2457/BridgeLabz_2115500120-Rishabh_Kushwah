using System;

namespace AddTwoNumbers
{
    class AddTwoNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            string input1 = Console.ReadLine();
            double number1 = Convert.ToDouble(input1);

            Console.WriteLine("Enter the second number:");
            string input2 = Console.ReadLine();
            double number2 = Convert.ToDouble(input2);

            double sum = number1 + number2;

            Console.WriteLine("The sum of {0} and {1} is {2}.", number1, number2, sum);
        }
    }
}
