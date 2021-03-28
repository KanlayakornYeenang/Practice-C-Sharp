using System;

namespace The_Nim
{
    class TheNim
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The number of boxes in bucket 1 : ");
            int b1 = int.Parse(Console.ReadLine());

            Console.WriteLine("The number of boxes in bucket 2 : ");
            int b2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The number of boxes in bucket 3 : ");
            int b3 = int.Parse(Console.ReadLine());

            int i = 0;

            while (b1 + b2 + b3 > 0)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine("A turn");
                }
                else
                {
                    Console.WriteLine("B turn");
                }

                Console.WriteLine("Choose bucket");
                int x = int.Parse(Console.ReadLine());

                Console.WriteLine("The number of boxes to be removed : ");
                int y = int.Parse(Console.ReadLine());

                if (x == 1)
                {
                    b1 -= y;
                }

                if (x == 2)
                {
                    b2 -= y;
                }

                if (x == 3)
                {
                    b3 -= y;
                }

                i += 1;

            }

            if (i % 2 == 0)
            {
                Console.WriteLine("A win");
            }

            else
            {
                Console.WriteLine("B win");
            }
        }
    }
}
