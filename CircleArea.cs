using System;

namespace CircleArea
{
    class CircleArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the circle:");
            string input = Console.ReadLine();
            double radius = Convert.ToDouble(input);

            double area = Math.PI * radius * radius;

            Console.WriteLine("The area of the circle with radius {0} is {1}.", radius, area);
        }
    }
}
