using System;

class BMI
{
    // Method calculates the bmi and puts value in data
    public static void CalculateBMI(double[,] data)
    {
        for (int i = 0; i < data.GetLength(0); i++)
        {
            double weight = data[i, 0];
            double height = data[i, 1];
            height /= 100;
            data[i, 2] = weight / (height * height);
        }
    }

    // Method to calculate the bmi status
    public static string[] CalculateBMIStatus(double[,] data)
    {
        string[] status = new string[data.GetLength(0)];
        // For loop to iterate over data
        for (int i = 0; i < data.GetLength(0); i++)
        {
            double bmi = data[i, 2];
            // Check the bmi conditions
            if (bmi <= 18.4)
                status[i] = "Underweight";
            else if (bmi >= 18.5 && bmi <= 24.9)
                status[i] = "Normal";
            else if (bmi >= 25.0 && bmi <= 39.9)
                status[i] = "OverWeight";
            else
                status[i] = "Obese";
        }
        // Return array
        return status;
    }

    static void Main(string[] args)
    {
        // Initialize array
        double[,] personsData = new double[10, 3];

        // Loop to take input height and weight
        for (int i = 0; i < personsData.GetLength(0); i++)
        {
            Console.Write($"Enter the weight (in kg) of Person {i + 1}: ");
            double kilogram = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Enter the height (in cm) of Person {i + 1}: ");
            double height = Convert.ToDouble(Console.ReadLine());
            personsData[i, 0] = kilogram;
            personsData[i, 1] = height;
        }

        // Call the CalculateBMI method
        CalculateBMI(personsData);

        // Call the CalculateBMIStatus method
        string[] bmiStatus = CalculateBMIStatus(personsData);

        // Display output using string.Format
        for (int i = 0; i < personsData.GetLength(0); i++)
        {
            Console.WriteLine(string.Format("Person {0} weight {1}, height {2} \nhave bmi {3:0.000} and bmi status {4}",
                i + 1, personsData[i, 0], personsData[i, 1], personsData[i, 2], bmiStatus[i]));
        }
    }
}



