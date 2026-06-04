using System;

class Program
{
    static void Main()
    {
        int score = 0;

        Console.WriteLine("What is 5 + 5 ?");
        int ans = Convert.ToInt32(Console.ReadLine());

        if (ans == 10)
        {
            score++;

            Console.WriteLine("Correct!");
        }
        else
        {
            Console.WriteLine("Wrong!");
        }

        Console.WriteLine("Final Score: " + score);
    }
}