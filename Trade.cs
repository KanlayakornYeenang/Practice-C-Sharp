using System;

namespace ConsoleApp4
{
    public class Trade
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose your mode (time/price) : ");
            string mode = Console.ReadLine();

            bool checkmode = (mode == "price" || mode == "time");
            if (checkmode == false)
            {
                Console.WriteLine("Invalid mode");
            }

            Console.WriteLine("Insert your position mouse (x) : ");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert your position mouse (y) : ");
            double y = double.Parse(Console.ReadLine());

            bool checktime = (mode == "time" && x > 0 && mode != "price");
            if (checktime == true)
            {
                Console.WriteLine(x + " , " + (x - 1) * (x - 1));
            }
            else if (x < 0 && mode == "time")
            {
                Console.WriteLine("Invalid mouse position");
            }

            bool checkprice = (mode == "price" && mode != "time");
            if (checkprice == true)
            {
                Console.WriteLine(Math.Sqrt(Math.Abs(y)) + " , " + y);
            }
        }
    }
}