using System;

// Defining a class HotelBooking
class HotelBooking
{
    private string guestName;
    private string roomType;
    private int nights;

    public string GuestName
    {
        get { return guestName; }
        set { guestName = value; }
    }

    public string RoomType
    {
        get { return roomType; }
        set { roomType = value; }
    }

    public int Nights
    {
        get { return nights; }
        set { nights = value; }
    }

    // Default Constructor
    public HotelBooking()
    {
        GuestName = "Guest";
        RoomType = "Single";
        Nights = 1;
    }

    // Parameterized Constructor
    public HotelBooking(string guestName, string roomType, int nights)
    {
        GuestName = guestName;
        RoomType = roomType;
        Nights = nights;
    }

    // Copy Constructor
    public HotelBooking(HotelBooking booking)
    {
        GuestName = booking.GuestName;
        RoomType = booking.RoomType;
        Nights = booking.Nights;
    }

    // Method to display the details of the booking
    public void Display()
    {
        Console.WriteLine(string.Format("Guest Name: {0}", GuestName));
        Console.WriteLine(string.Format("Room Type: {0}", RoomType));
        Console.WriteLine(string.Format("Number of Nights: {0}", Nights));
    }
}

class Program
{
    static void Main(string[] args)
    {
        HotelBooking booking1 = new HotelBooking(); // Using Default Constructor
        HotelBooking booking2 = new HotelBooking("Rishabh", "Single", 3); // Using Parameterized Constructor
        HotelBooking booking3 = new HotelBooking(booking2); // Using Copy Constructor
        
        Console.WriteLine("Booking 1:");
        booking1.Display();

        Console.WriteLine("\nBooking 2:");
        booking2.Display();

        Console.WriteLine("\nBooking 3 (Copied):");
        booking3.Display();
    }
}
