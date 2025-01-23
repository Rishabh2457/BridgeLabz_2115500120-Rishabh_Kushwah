using System;

class RocketLaunch2
{
    public static void Main(string[] args)
    {
        StartCountdown();
    }
    
    // Method to perform countdown using a for-loop
    public static void StartCountdown()
    {
        Console.Write("Enter the countdown start value: ");
        int counter = Convert.ToInt32(Console.ReadLine());

        // Perform the countdown using a for-loop
        for (int i = counter; i >= 1; i--)
        {
            Console.WriteLine(i);
        }

        // Print the rocket launch message
        Console.WriteLine("Rocket Launching");
    }
}
