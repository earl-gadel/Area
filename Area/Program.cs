using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double radius;
            double area;

            Console.WriteLine("Enter a radius: ");
            input = Console.ReadLine();
            radius = double.Parse(input);
            do
            {
                string message = "Enter a positive number.";
                Console.WriteLine(message);
                Console.WriteLine("Enter a radius: ");
                input = Console.ReadLine();
                radius = double.Parse(input);
            } while (radius < 0);
            area = 3.14159 * radius * radius;
            Console.WriteLine("The area of a circle with radius {0} is: {1}", radius, area);
            Console.ReadLine();
        }
    }
}
