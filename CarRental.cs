using System;

// Defining a class CarRental
public class CarRental
{
    private string customerName;
    private string carModel;
    private int rentalDays;
    private double dailyRate;

    public string CustomerName
    {
        get { return customerName; }
        set { customerName = value; }
    }

    public string CarModel
    {
        get { return carModel; }
        set { carModel = value; }
    }

    public int RentalDays
    {
        get { return rentalDays; }
        set { rentalDays = value; }
    }

    public double DailyRate
    {
        get { return dailyRate; }
        set { dailyRate = value; }
    }

    // Parameterized constructor
    public CarRental(string customerName, string carModel, int rentalDays, double dailyRate)
    {
        CustomerName = customerName;
        CarModel = carModel;
        RentalDays = rentalDays;
        DailyRate = dailyRate;
    }

    // Method to calculate the total cost of the rental
    public double CalculateTotalCost()
    {
        return RentalDays * DailyRate;
    }

    // Display method
    public void Display()
    {
        Console.WriteLine("Rental Details:");
        Console.WriteLine(string.Format("Customer: {0}", CustomerName));
        Console.WriteLine(string.Format("Car Model: {0}", CarModel));
        Console.WriteLine(string.Format("Rental Days: {0}", RentalDays));
        Console.WriteLine(string.Format("Daily Rate: ₹{0:F2}", DailyRate));
        Console.WriteLine(string.Format("Total Cost: ₹{0:F2}", CalculateTotalCost()));
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Using Parameterized Constructor
        CarRental rental = new CarRental("John Doe", "Toyota Camry", 5, 30.0);
        rental.Display(); // Calling the Display method
    }
}
