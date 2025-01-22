using System;

class HeightConverter
{
    public static void Main(string[] args)
    {
        ConvertHeight();
    }

    // Method to convert height in cm to feet and inches
    public static void ConvertHeight()
    {
        Console.Write("Enter your height in centimeters: ");
        double heightCm = Convert.ToDouble(Console.ReadLine());
        
        double totalInches = heightCm / 2.54;
        int feet = (int)(totalInches / 12);
        double inches = totalInches % 12;

        Console.WriteLine(string.Format("Your Height in cm is {0} while in feet is {1} and inches is {2:F2}", heightCm, feet, inches));
    }
}
