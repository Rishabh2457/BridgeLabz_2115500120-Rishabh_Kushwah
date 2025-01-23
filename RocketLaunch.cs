using System;

class RocketLaunch
{
    public static void Main(string[] args)
    {
        StartCountdown();
    }
    
    // Method to perform countdown
    public static void StartCountdown()
    {
        Console.Write("Enter the countdown start value: ");
        int counter = Convert.ToInt32(Console.ReadLine());

        // Perform the countdown
        while (counter >= 1)
        {
            Console.WriteLine(counter);
            counter--; // Decrement the counter
        }

        // Print the rocket launch message
        Console.WriteLine("Rocket Launching");
    }
}
