using System;

namespace Homework_6
{
    class hw6
    {
        enum Difficulty
        {
            Easy,
            Normal,
            Hard
        }
        struct Problem
        {
            public string Message;
            public int Answer;

            public Problem(string message, int answer)
            {
                Message = message;
                Answer = answer;
            }
        }
        static Problem[] GenerateRandomProblems(int numProblem)
        {
            Problem[] randomProblems = new Problem[numProblem];

            Random rnd = new Random();
            int x, y;

            for (int i = 0; i < numProblem; i++)
            {
                x = rnd.Next(50);
                y = rnd.Next(50);
                if (rnd.NextDouble() >= 0.5)
                    randomProblems[i] =
                    new Problem(String.Format("{0} + {1} = ?", x, y), x + y);
                else
                    randomProblems[i] =
                    new Problem(String.Format("{0} - {1} = ?", x, y), x - y);
            }

            return randomProblems;
        }
        static int check(int x)
        {
            while (x < 0 || x > 2)
            {
                Console.WriteLine("Please input 0 - 2.");
                x = int.Parse(Console.ReadLine());
            }
            return x;
        }
        static void Main(string[] args)
        {
            int correct = 0;
            double score = 0;
            int inputlevel = 0;

            Difficulty level;
            level = (Difficulty)inputlevel;

            Console.WriteLine("Score: {0}, Difficulty: {1}", score, level);
            int go = int.Parse(Console.ReadLine());
            go = check(go);

            while (go != 2)
            {
                int num = 0;
                if (go == 0)
                {
                    if (level.ToString() == "Easy")
                    {
                        num += 3;
                    }
                    if (level.ToString() == "Normal")
                    {
                        num += 5;
                    }
                    if (level.ToString() == "Hard")
                    {
                        num += 7;
                    }
                    Problem[] problem = GenerateRandomProblems(num);
                    long timestart = DateTimeOffset.Now.ToUnixTimeSeconds();
                    for (int i = 0; i < GenerateRandomProblems(num).Length; i++)
                    {
                        Console.WriteLine(problem[i].Message);
                        int ans = int.Parse(Console.ReadLine());
                        if (ans == problem[i].Answer)
                        {
                            correct += 1;
                        }
                    }
                    long timeover = DateTimeOffset.Now.ToUnixTimeSeconds();
                    long countime = timeover - timestart;
                    score = (correct / num) * 25 - Math.Pow((int)level, 2) / Math.Max(countime, 25 - Math.Pow((int)level, 2)) * Math.Pow((2 * (int)level) + 1, 2);
                }

                if (go == 1)
                {
                    inputlevel = int.Parse(Console.ReadLine());
                    check(inputlevel);
                    inputlevel = check(inputlevel);
                    level = (Difficulty)inputlevel;
                }

                Console.WriteLine("Score: {0}, Difficulty: {1}", score, level);
                go = int.Parse(Console.ReadLine());
                check(go);
            }
        }
    }
}