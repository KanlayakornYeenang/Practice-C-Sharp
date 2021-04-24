using System;

namespace Complex
{
    class Complex
    {
        static void Main(string[] args)
        {
            float aa, bb,c,d;
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            string op = Console.ReadLine();
            while (op == "+" || op == "-" || op == "*" || op == "/" || op == "^" || op == "|")
            {
                aa = a;
                bb = b;
                if (op == "+")
                {
                    c = float.Parse(Console.ReadLine());
                    d = float.Parse(Console.ReadLine());
                    a = aa + c;
                    b = bb + d;
                }
                else if (op == "-")
                {
                    c = float.Parse(Console.ReadLine());
                    d = float.Parse(Console.ReadLine());
                    a = aa - c;
                    b = bb - d;
                }
                else if (op == "*")
                {
                    c = float.Parse(Console.ReadLine());
                    d = float.Parse(Console.ReadLine());
                    a = aa * c - bb * d;
                    b = aa * d + bb * c;
                }
                else if (op == "/")
                {
                    c = float.Parse(Console.ReadLine());
                    d = float.Parse(Console.ReadLine());
                    a = (aa * c + bb * d) / (c * c + d * d);
                    b = (bb * c - aa * d) / (c * c + d * d);
                }
                else if (op == "^")
                {
                    c = float.Parse(Console.ReadLine());
                    if (c == 0)
                    {
                        a = 1;
                        b = 0;
                    }
                    else
                    {
                        //อิอิ
                    }
                }
                else if (op == "|")
                {
                    a = (float)Math.Sqrt((aa*aa)+(bb*bb));
                    b = 0;
                }
                Console.Write(a);
                Console.Write(b);
                Console.Write("i");
                op = Console.ReadLine();
            }
        }
    }
}
