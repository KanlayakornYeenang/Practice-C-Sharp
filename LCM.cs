using System;

namespace LCM
{
    class LCM
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number a : ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Input number b : ");
            int b = int.Parse(Console.ReadLine());

            int x = a;
            int y = b;

            do
            {
                if (x < y)
                {
                    x = x + a;
                }
                else
                {
                    y = y + b;
                }
            } while (x != y);

            Console.WriteLine(x);
        }
    }
}
