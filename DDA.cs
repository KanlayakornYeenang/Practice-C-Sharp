using System;

namespace DDA
{
    class DDA
    {
        static void Main(string[] args)
        {
            float x, y, dx, dy, step;
            float x1 = float.Parse(Console.ReadLine());
            float y1 = float.Parse(Console.ReadLine());
            float x2 = float.Parse(Console.ReadLine());
            float y2 = float.Parse(Console.ReadLine());

            dx = x2 - x1;
            dy = y2 - y1;

            if (Math.Abs(dx) >= Math.Abs(dy))
            {
                step = Math.Abs(dx);
                dx /= step;
                dy /= step;
                x = x1;
                y = y1;
                int i = 1;
                while (i <= step)
                {
                    Console.Write(x);
                    Console.Write(",");
                    Console.Write(y);
                    x += dx;
                    y += dy;
                    i++;
                }
            }

            else
            {
                step = Math.Abs(dy);
                dx /= step;
                dy /= step;
                x = x1;
                y = y1;
                int i = 1;
                while (i <= step)
                {
                    Console.Write(x);
                    Console.Write(",");
                    Console.Write(y);
                    x += dx;
                    y += dy;
                    i++;
                }
            }
        }
    }
}
