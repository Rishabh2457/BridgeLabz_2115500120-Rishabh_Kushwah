using System;

// Defining a class Product
class Product
{
    private string productName;
    private int price;
    static int totalProducts = 100;

    public string ProductName
    {
        get { return productName; }
        set { productName = value; }
    }

    public int Price
    {
        get { return price; }
        set { price = value; }
    }

    // Instance method to display the product details
    public void DisplayProductDetails()
    {
        Console.WriteLine(string.Format("Product Name: {0}", ProductName));
        Console.WriteLine(string.Format("Price: ${0}", Price));
    }

    // Static method to display the total number of products
    public static void DisplayTotalProducts()
    {
        Console.WriteLine(string.Format("Total Products: {0}", totalProducts));
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of the Product class
        Product product1 = new Product();
        product1.ProductName = "Laptop";
        product1.Price = 4500;
        product1.DisplayProductDetails();

        // Calling the static method using the class name
        Product.DisplayTotalProducts();
    }
}
