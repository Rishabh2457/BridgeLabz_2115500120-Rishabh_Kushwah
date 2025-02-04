using System;

// Defining a class Vehicle
public class Vehicle
{
    private string ownerName;
    private string vehicleType;
    private static double registrationFee = 0.0;  // Initialized with default value

    // Parameterized constructor
    public Vehicle(string ownerName, string vehicleType)
    {
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
    }

    // Display method
    public void DisplayVehicleDetails()
    {
        Console.WriteLine(string.Format("Owner Name: {0}", ownerName));
        Console.WriteLine(string.Format("Vehicle Type: {0}", vehicleType));
        Console.WriteLine(string.Format("Registration Fee: {0}", registrationFee));
    }

    // Static method to update the registration fee
    public static void UpdateRegistrationFee(double newFee)
    {
        registrationFee = newFee;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Update the registration fee
        Vehicle.UpdateRegistrationFee(100.0);

        // Create an instance of the Vehicle class
        Vehicle vehicle1 = new Vehicle("Rishabh Kushwah", "Truck");
        vehicle1.DisplayVehicleDetails();

        // Create another instance
        Vehicle vehicle2 = new Vehicle("Rishabh Kushwah", "Bike");
        vehicle2.DisplayVehicleDetails();
    }
}
