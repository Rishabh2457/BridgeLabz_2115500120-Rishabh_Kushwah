using System;

class Product
{
    // Static variable shared by all products
    private static double Discount = 10.0; // Default discount percentage

    // Readonly variable (cannot be modified after initialization)
    public readonly int ProductID;
    public string ProductName;
    public double Price;
    public int Quantity;

    // Constructor using 'this' keyword to initialize attributes
    public Product(int ProductID, string ProductName, double Price, int Quantity)
    {
        this.ProductID = ProductID; // Readonly variable can only be assigned here
        this.ProductName = ProductName;
        this.Price = Price;
        this.Quantity = Quantity;
    }

    // Static method to update discount percentage
    public static void UpdateDiscount(double newDiscount)
    {
        Discount = newDiscount;
        Console.WriteLine("Discount updated to: " + Discount + "%");
    }

    // Method to display product details (checks instance using 'is' operator)
    public void DisplayProductDetails()
    {
        if (this is Product)
        {
            Console.WriteLine("Product ID: " + ProductID);
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("Price: $" + Price);
            Console.WriteLine("Quantity: " + Quantity);
            Console.WriteLine("Discount: " + Discount + "%");
        }
        else
        {
            Console.WriteLine("Invalid product object.");
        }
    }
}

class Product_Details
{
    static void Main()
    {
        // Creating Product objects
        Product prod1 = new Product(101, "Laptop", 1200.99, 2);
        Product prod2 = new Product(102, "Smartphone", 699.50, 5);

        // Display product details
        prod1.DisplayProductDetails();
        Console.WriteLine();
        prod2.DisplayProductDetails();
        Console.WriteLine();

        // Update discount percentage
        Product.UpdateDiscount(15.0);
        Console.WriteLine();
	}
}