using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insert password : ");
        int password = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Insert unit : ");
        string unit = Console.ReadLine();

        int p6 = (password / 100000);
        int p5 = (password / 10000) - (p6 * 10);
        int p4 = (password / 1000) - (p5 * 10) - (p6 * 100);
        int p3 = (password / 100) - (p4 * 10) - (p5 * 100);
        int p2 = (password / 10) - (p3 * 10) - (p4 * 100);
        int p1 = password - (p6 * 100000) - (p5 * 10000);

        bool checkCIA = (unit == "CIA") && (p1 % 3 == 0) && (p2 != 1 && p2 != 3 && p2 != 5) && (p4 >= 6 && 94 != 8);
        bool checkFBI = (unit == "FBI") && (p6 >= 4 && p6 <= 7) && (p3 % 2 == 0 && p3 != 6) && (p5 % 2 == 1);
        bool checkNSA = (unit == "NSA") && (30 % p1 == 0) && (p3 % 3 == 0 && p3 % 2 != 0) && (p1 == 7 || p2 == 7 | p3 == 7 || p4 == 7 || p5 == 7 || p6 == 7);

        bool checkALL = checkCIA || checkFBI || checkNSA;
        Console.WriteLine(checkALL);
        Console.ReadLine();
    }
}
