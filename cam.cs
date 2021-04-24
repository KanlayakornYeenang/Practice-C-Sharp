using System;

namespace cam
{
    class cam
    {
        static void Main(string[] args)
        {
            string mode = Console.ReadLine();
            float filmBackWidth = float.Parse(Console.ReadLine());
            while (filmBackWidth < 0)
            {
                Console.WriteLine("Invalid filmBackWidth");
                filmBackWidth = float.Parse(Console.ReadLine());
            }
            float fLength, fov;
            if (filmBackWidth > 0)
            {
                if (mode == "fLength")
                {
                    fLength = float.Parse(Console.ReadLine());
                    while (fLength < 0)
                    {
                        Console.WriteLine("Invalid fLength. Please input again.");
                        fLength = float.Parse(Console.ReadLine());
                    }
                    fov = 2 * (float)Math.Atan2(filmBackWidth / 2, fLength);
                    Console.WriteLine("fLength = ", fLength, ",fov = ", fov);
                }
                else if (mode == "fov")
                {
                    Console.WriteLine("input fov");
                    fov = float.Parse(Console.ReadLine());
                    while (fov < 0.1 && fov > 6.28)
                    {
                        Console.WriteLine("Invalid fov. Plese input again.");
                        fov = float.Parse(Console.ReadLine());
                    }
                    if (fov > 0.1 && fov < 6.28)
                    {
                        fLength = filmBackWidth / (2 * (float)Math.Tan(fov / 2));
                        Console.WriteLine("fLength = ", fLength, ",fov = ", fov);
                    }
                }
            }
        }
    }
}
