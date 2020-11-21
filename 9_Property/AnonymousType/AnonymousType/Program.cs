using System;

namespace AnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new { Name = "박상현", Age = 12 };
            Console.WriteLine($"Name:{a.Name}, Age:{a.Age}");

            var b = new { Subject = "수박", Scores = new int[] { 90, 80, 70, 60 } };
            Console.WriteLine($"Subject:{b.Subject}, Scores :");
            foreach(var score in b.Scores )
            {
                Console.Write($"{score} ");
            }

            Console.WriteLine();
        }
    }
}
