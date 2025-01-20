using System;

namespace CylinderVolume
{
    class CylinderVol
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the cylinder:");
            string inputRadius = Console.ReadLine();
            double radius = Convert.ToDouble(inputRadius);

            Console.WriteLine("Enter the height of the cylinder:");
            string inputHeight = Console.ReadLine();
            double height = Convert.ToDouble(inputHeight);

   
            double volume = Math.PI * radius * radius * height;

            Console.WriteLine("The volume of the cylinder with radius {0} and height {1} is {2}.", radius, height, volume);
        }
    }
}
