using System;

class PrimeNumberChecker
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number to check if it is a Prime Number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number <= 1)
        {
            Console.WriteLine(string.Format("{0} is not a Prime Number.", number));
        }
        else
        {
            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine(string.Format("{0} is a Prime Number.", number));
            }
            else
            {
                Console.WriteLine(string.Format("{0} is not a Prime Number.", number));
            }
        }
    }
}
