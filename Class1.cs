using System;
using System.Collections.Generic;





public abstract class WareHouseItem
{
    public string Name { get; set; }
    public int Quantity {  get; set; }

    public WareHouseItem(string name ,int quantity)
    {
        Name = name;
        Quantity = quantity;
    }
    public abstract void DisplayItem();
}

public class Electronics : WareHouseItem
{   
    public string Brand {  get; set; }
    public Electronics(string name, int quantity,string brand) : base(name, quantity)
    {
        Brand = brand;
    }

    public override void DisplayItem()
    {
        Console.WriteLine($"[Electronics] Name :{Name},Quantity:{Quantity},Brand:{Brand}");
    }
}
public class Groceries : WareHouseItem
{
    public DateTime ExpiryDate { get; set; }
    public Groceries(string name, int quantity, DateTime expiryDate) : base(name, quantity)
    {
        ExpiryDate = expiryDate;
    }

    public override void DisplayItem()
    {
        Console.WriteLine($"[Groceries] Name :{Name},Quantity:{Quantity},ExpiryDate:{ExpiryDate}");
    }
}
public class Furniture : WareHouseItem
{
    public string Material { get; set; }
    public Furniture(string name, int quantity, string material) : base(name, quantity)
    {
        Material = material;
    }

    public override void DisplayItem()
    {
        Console.WriteLine($"[Furniture] Name :{Name},Quantity:{Quantity},Material:{Material}");
    }
}

public class Storage<T> where T: WareHouseItem
{
    private List<T> items = new List<T>();
    public void AddItem(T item)
{
    items.Add(item);
}
    public void DisplayAllItems()
{
    foreach(var item in items)
    {
        item.DisplayItem();
    }
}

}
    
class Program
{
    static void Main()
    {
        // Create storage for different types of warehouse items
        var electronicsStorage = new Storage<Electronics>();
        electronicsStorage.AddItem(new Electronics("Laptop", 10, "Dell"));
        electronicsStorage.AddItem(new Electronics("Smartphone", 20, "Samsung"));

        var groceriesStorage = new Storage<Groceries>();
        groceriesStorage.AddItem(new Groceries("Apple", 50, DateTime.Now.AddDays(7)));
        groceriesStorage.AddItem(new Groceries("Milk", 30, DateTime.Now.AddDays(3)));

        var furnitureStorage = new Storage<Furniture>();
        furnitureStorage.AddItem(new Furniture("Chair", 15, "Wood"));
        furnitureStorage.AddItem(new Furniture("Table", 10, "Metal"));

        // Display items for each category
        electronicsStorage.DisplayAllItems();
        groceriesStorage.DisplayAllItems();
        furnitureStorage.DisplayAllItems();
    }
}
