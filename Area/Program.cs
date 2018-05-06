using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double r;
            double a;

            Console.WriteLine("Enter a radius: ");
            input = Console.ReadLine();
            r = double.Parse(input);
            do
            {
                string message = "Enter a positive number.";
                Console.WriteLine(message);
                Console.WriteLine("Enter a radius: ");
                input = Console.ReadLine();
                r = double.Parse(input);
            } while (r < 0);
            a = 3.14159 * r * r;
            Console.WriteLine("The area of a circle with radius {0} is: {1}", r, a);
            Console.ReadLine();
        }
    }
}
