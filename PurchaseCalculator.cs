using System;

class PurchaseCalculator
{
    public static void Main(string[] args)
    {
        CalculateTotalPrice();
    }

    // Method to calculate the total purchase price
    public static void CalculateTotalPrice()
    {
        Console.Write("Enter the unit price of the item (in INR): ");
        double unitPrice = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the quantity to be bought: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        // Calculate total price
        double totalPrice = unitPrice * quantity;

        // Display the result
        Console.WriteLine(string.Format(
            "The total purchase price is INR {0:F2} if the quantity is {1} and the unit price is INR {2:F2}.",
            totalPrice, quantity, unitPrice));
    }
}
