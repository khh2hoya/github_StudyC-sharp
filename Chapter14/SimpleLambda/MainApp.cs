using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLambda
{
    
    class MainApp
    {
        delegate int Calculate(int a, int b);
        static void Main(string[] args)
        {
            Calculate calcPlus = (a, b) => a + b;
            Calculate calcMinus = (a, b) => a - b;

            Console.WriteLine($"{3} + {4} = {calcPlus(3, 4)}");
            Console.WriteLine($"{3} - {4} = {calcMinus(3, 4)}");


        }
    }
}
