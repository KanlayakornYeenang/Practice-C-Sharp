using System;

namespace Heaven_stair
{
    class Heaven_stair
    {
        static void Main(string[] args)
        {
            string pp;
            string s = Console.ReadLine();
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int e = 0; e < h; e++)
                {
                    pp = " ";
                    for (int j = 0; j < w; j++)
                    {
                        pp += s;
                    }
                    //pp = pp * (i + 1);
                    Console.WriteLine(pp);
                }
            }
        }
    }
}
