using System;

class Calculator
{
    public static void Main(string[] args)
    {
        // Declare variables
        double first, second;
        string op;

        // Get input from the user
        Console.Write("Enter first number: ");
        first = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        second = double.Parse(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        op = Console.ReadLine();

        // Use switch-case to perform the operation based on the operator
        double result = 0;
        bool isValidOperator = true;

        switch (op)
        {
            case "+":
                result = first + second;
                break;
            case "-":
                result = first - second;
                break;
            case "*":
                result = first * second;
                break;
            case "/":
                if (second != 0)
                    result = first / second;
                else
                {
                    Console.WriteLine("Error: Division by zero.");
                    isValidOperator = false;
                }
                break;
            default:
                Console.WriteLine("Invalid Operator");
                isValidOperator = false;
                break;
        }

        // If a valid operator is used, display the result
        if (isValidOperator)
            Console.WriteLine(string.Format("The result of {0} {1} {2} = {3}",first,op,second,result));
    }
}
