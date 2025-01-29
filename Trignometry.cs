using System;

class Trigonometry
{
    // Method to calculate sine, cosine, and tangent for a given angle
    public double[] CalculateTrigonometricFunctions(double angle)
    {
        // Convert angle from degrees to radians
        double angleInRadians = Math.PI * angle / 180.0;
        // Calculate sine, cosine, and tangent
        double sine = Math.Sin(angleInRadians);
        double cosine = Math.Cos(angleInRadians);
        double tangent = Math.Tan(angleInRadians);
        // Return an array
        return new double[] { sine, cosine, tangent };
    }

    static void Main(string[] args)
    {
        // Input angle from user
        Console.Write("Enter the angle in degrees: ");
        double angle = Convert.ToDouble(Console.ReadLine());
        
        // Create the class instance
        Trigonometry trigonometry = new Trigonometry();
        
        // Call the method 
        double[] results = trigonometry.CalculateTrigonometricFunctions(angle);

        // Display the results using string.Format
        Console.WriteLine(string.Format("Sine({0}°): {1:0.0000}", angle, results[0]));
        Console.WriteLine(string.Format("Cosine({0}°): {1:0.0000}", angle, results[1]));
        Console.WriteLine(string.Format("Tangent({0}°): {1:0.0000}", angle, results[2]));
    }
}
