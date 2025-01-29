using System;

class NumberChecker
{
    public static int[] GetFactors(int num)
    {
        int count = 0;
        // Loop to count the factors
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                count++;
            }
        }

        int[] factors = new int[count];
        int index = 0;
        // Store factors in array
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                factors[index] = i;
                index++;
            }
        }
        // Return factor array
        return factors;
    }

    // Method to calculate greatest factor
    public static int GreatestFactor(int[] factors)
    {
        // Second last element
        return factors[factors.Length - 2];
    }

    public static int SumOfFactors(int[] factors)
    {
        int sum = 0;
        // Loop to sum the factors
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    // Method to get the product of factors
    public static long ProductOfFactors(int[] factors)
    {
        long product = 1;
        // Loop to product the factors
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    // Method to get the product of cubes of factors
    public static long ProductOfCubeOfFactors(int[] factors)
    {
        long product = 1;
        // Loop to get cubes of factors product
        foreach (int factor in factors)
        {
            product *= (long)Math.Pow(factor, 3);
        }
        return product;
    }

    // Method to check if the number is a perfect number or not
    public static bool IsPerfectNumber(int num)
    {
        int[] factors = GetFactors(num);
        // Call the SumOfFactors method
        int sum = SumOfFactors(factors) - num; // Do not include the number
        return sum == num;
    }

    public static bool IsAbundantNumber(int num)
    {
        int[] factors = GetFactors(num);
        // Call the SumOfFactors method
        int sum = SumOfFactors(factors) - num; // Do not include the number
        return sum > num;
    }

    public static bool IsDeficientNumber(int num)
    {
        int[] factors = GetFactors(num);
        // Call the SumOfFactors method
        int sum = SumOfFactors(factors) - num; // Do not include the number
        return sum < num;
    }

    // Method to calculate factorial
    public static long Factorial(int num)
    {
        int factorial = 1;
        for (int i = 2; i <= num; i++)
        {
            factorial *= i;
        }
        return factorial;
    }

    // Method to check the strong number (sum of digits == factorial)
    public static bool IsStrongNumber(int num)
    {
        int sum = 0;
        long factorial = Factorial(num);
        while (num != 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum == factorial;
    }

    static void Main(string[] args)
    {
        // Input from user
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        // Call the method GetFactors
        int[] factors = GetFactors(num);

        // Display output using string.Format
        Console.WriteLine(string.Format("Greatest Factor: {0}", GreatestFactor(factors)));
        Console.WriteLine(string.Format("Sum of Factors: {0}", SumOfFactors(factors)));
        Console.WriteLine(string.Format("Product of Factors: {0}", ProductOfFactors(factors)));
        Console.WriteLine(string.Format("Product of Cubes of Factors: {0}", ProductOfCubeOfFactors(factors)));
        Console.WriteLine(string.Format("Is Perfect Number: {0}", IsPerfectNumber(num)));
        Console.WriteLine(string.Format("Is Abundant Number: {0}", IsAbundantNumber(num)));
        Console.WriteLine(string.Format("Is Deficient Number: {0}", IsDeficientNumber(num)));
        Console.WriteLine(string.Format("Is Strong Number: {0}", IsStrongNumber(num)));
    }
}