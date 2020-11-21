using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingGenericList
{
    class MainApp
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
                list.Add(i);

            foreach (int e in list)
                Console.Write($"{e} ");
            Console.WriteLine();

            list.RemoveAt(2);
            foreach (int e in list)
                Console.Write($"{e} ");
            Console.WriteLine();

            list.Insert(2, 2);
            foreach (int e in list)
                Console.Write($"{e} ");
            Console.WriteLine();

        }
    }
}
