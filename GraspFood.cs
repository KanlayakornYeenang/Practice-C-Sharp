using System;

namespace GraspFood
{
    class GraspFood
    {
        static void Main(string[] args)
        {
            int dow = int.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            string menu = "bruh";
            int breakfastset = 5;
            int weekendset = 2;
            int coffeeset = 4;
            while (menu != "End")
            {
                while (menu != "Breakfast Set" && menu != "Weekend Set" && menu != "Coffee" && menu != "bruh")
                {
                    Console.WriteLine("Please enter a valid menu");
                    menu = Console.ReadLine();
                }
                if (menu == "Breakfast Set")
                {
                    if (time > 11)
                    {
                        Console.WriteLine("Sorry your order is not available");
                    }
                    else if (breakfastset == 0)
                    {
                        Console.WriteLine("Sorry your order is out of stock");
                    }
                    else
                    {
                        breakfastset -= 1;
                    }
                }
                else if (menu == "Weekend Set")
                {
                    if (dow >= 1 && dow <= 5)
                    {
                        Console.WriteLine("Sorry your order is not available");
                    }
                    else if (weekendset == 0)
                    {
                        Console.WriteLine("Sorry your order is out of stock");
                    }
                    else
                    {
                        weekendset -= 1;
                    }
                }
                else if (menu == "Coffee")
                {
                    if (coffeeset == 0)
                    {
                        Console.WriteLine("Sorry your order is out of stock");
                    }
                    else
                    {
                        coffeeset -= 1;
                    }
                }
                menu = Console.ReadLine();
            }
        }
    }
}
