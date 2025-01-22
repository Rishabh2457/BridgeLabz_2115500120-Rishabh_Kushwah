using System;

class ChocolateDivision
{
    public static void Main(string[] args)
    {
        DivideChocolates();
    }

    // Method to divide chocolates among children
    public static void DivideChocolates()
    {
        // Taking user input 
        Console.Write("Enter the total number of chocolates: ");
        int numOfChoco = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of children: ");
        int numOfChildren = Convert.ToInt32(Console.ReadLine());

        // Calculating chocolates each child gets and remaining chocolates
        int chocoPerChild = numOfChoco / numOfChildren;
        int remainingChoco = numOfChoco % numOfChildren;

        // Displaying the results
        Console.WriteLine(string.Format(
            "The number of chocolates each child gets is {0} and the number of remaining chocolates is {1}.",
            chocoPerChild, remainingChoco));
    }
}
