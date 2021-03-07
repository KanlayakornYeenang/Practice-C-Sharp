using System;

namespace Trade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your mode (time/price) : ");
            string mode;
            mode = Console.ReadLine();

            while (mode != "price" && mode != "time")
            {
                Console.WriteLine("Invalid mode");
                Console.WriteLine("Choose your mode (time/price) : ");
                mode = Console.ReadLine();
            }

            Console.WriteLine("Insert your position mouse (x) : ");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert your position mouse (y) : ");
            double y = double.Parse(Console.ReadLine());

            if (mode == "price" && mode != "time" && x > 0)
            {
                Console.WriteLine(Math.Sqrt(Math.Abs(y)) + " , " + y);
            }

            else if (mode == "price" && mode != "time" && x < 0)
            {
                Console.WriteLine("Invalid mouse position");
            }

            else if (mode == "time" && mode != "price" && x > 0)
            {
                Console.WriteLine(x + " , " + (x - 1) * (x - 1));
            }

            else if (mode == "time" && mode != "price" && x < 0)
            {
                Console.WriteLine("Invalid mouse position");
            }
        }
    }
}
