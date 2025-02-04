using System;

class Vehicle
{
    // Static variable shared among all vehicles
    private static double RegistrationFee = 500.0;

    // Readonly variable to uniquely identify each vehicle
    public readonly int RegistrationNumber;
    public string OwnerName;
    public string VehicleType;

    // Constructor using 'this' keyword to initialize attributes
    public Vehicle(int registrationNumber, string ownerName, string vehicleType)
    {
        this.RegistrationNumber = registrationNumber; // Readonly variable assigned in constructor
        this.OwnerName = ownerName;
        this.VehicleType = vehicleType;
    }

    // Static method to update registration fee
    public static void UpdateRegistrationFee(double newFee)
    {
        RegistrationFee = newFee;
    }

    // Method to display vehicle registration details (checks instance using 'is' operator)
    public void DisplayVehicleDetails()
    {
        if (this is Vehicle)
        {
            Console.WriteLine("Owner: " + OwnerName);
            Console.WriteLine("Vehicle Type: " + VehicleType);
            Console.WriteLine("Registration Number: " + RegistrationNumber);
            Console.WriteLine("Registration Fee: $" + RegistrationFee);
        }
        else
        {
            Console.WriteLine("Invalid vehicle object.");
        }
    }
}

class Vehicle_Details
{
    static void Main()
    {
        // Creating Vehicle objects
        Vehicle car1 = new Vehicle(1001, "Alice Johnson", "Car");
        Vehicle bike1 = new Vehicle(1002, "Bob Smith", "Motorcycle");

        // Display vehicle details
        car1.DisplayVehicleDetails();
        Console.WriteLine("----------------------");
        bike1.DisplayVehicleDetails();
        Console.WriteLine("----------------------");

        // Update registration fee and display updated details
        Vehicle.UpdateRegistrationFee(600.0);
        Console.WriteLine("Updated Registration Fee:");
        car1.DisplayVehicleDetails();
        Console.WriteLine("-----------------");
        bike1.DisplayVehicleDetails();
    }
}
