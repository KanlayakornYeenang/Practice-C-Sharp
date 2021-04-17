using System;

namespace Pascal
{
    class Pascal
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());

            while (r < 0)
            {
                Console.WriteLine("Invalid Pascal’s triangle row number.");
                r = int.Parse(Console.ReadLine());
            }

            r += 1;
            int x = 1 , i , j;
            for (i = 0; i < r; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                        x = 1;
                    else
                        x = x * (i - j + 1) / j;
                    Console.Write(x + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
