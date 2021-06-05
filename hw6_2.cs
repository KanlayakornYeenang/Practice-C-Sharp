using System;

namespace Homework_6_2
{
    class hw6_2
    {
        static void Main(string[] args)
        {
            int amount, paid, change;
            Console.WriteLine("Enter amount of product");
            amount = int.Parse(Console.ReadLine());
            while (amount <= 0)
            {
                Console.WriteLine("Please enter again");
                amount = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter amount of paid");
            paid = int.Parse(Console.ReadLine());
            while (paid < amount)
            {
                Console.WriteLine("Please enter again");
                paid = int.Parse(Console.ReadLine());
            }

            change = paid - amount;
            Console.WriteLine("Change money total is " + change + " Baht.");
            if (change >= 1000)
            {
                Console.WriteLine("1000 Baht: " + change/ 1000);
                change = change % 1000;
            }

            if (change >= 500)
            {
                Console.WriteLine("500 Baht: " + change / 500);
                change = change % 500;
            }

            if (change >= 100)
            {
                Console.WriteLine("100 Baht: " + change / 100);
                change = change % 100;
            }

            if (change >= 50)
            {
                Console.WriteLine("50 Baht: " + change / 50);
                change = change % 50;
            }

            if (change >= 20)
            {
                Console.WriteLine("20 Baht: " + change / 20);
                change = change % 20;
            }

            if (change >= 10)
            {
                Console.WriteLine("10 Baht: " + change / 10);
                change = change % 10;
            }

            if (change >= 5)
            {
                Console.WriteLine("1000 Baht: " + change / 5);
                change = change % 5;
            }

            if (change >= 2)
            {
                Console.WriteLine("2 Baht: " + change / 2);
                change = change % 2;
            }

            if (change >= 1)
            {
                Console.WriteLine("1 Baht: " + change / 1);
            }
        }
    }
}
