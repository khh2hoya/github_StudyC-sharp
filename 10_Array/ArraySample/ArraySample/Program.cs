using System;

namespace ArraySample
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];
            scores[0] = 80;
            scores[1] = 74;
            scores[2] = 81;
            scores[3] = 90;
            scores[4] = 34;

            int sum = 0;
            foreach( int score in scores)
            {
                Console.WriteLine(score);
                sum += score;
            }

            int average = sum / scores.Length;

            Console.WriteLine($"Average Score : {average}");
        }
    }
}
