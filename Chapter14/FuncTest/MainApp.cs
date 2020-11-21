using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncTest
{
    class MainApp
    {
        static void Main(string[] args)
        {

            //Func 대리자.

            Func<int> func1 = () => 10;
            Console.WriteLine($"func1()  : {func1()}");

            Func<int, int> func2 = (a) => a * a;
            Console.WriteLine($"func2(9) : {func2(9)}");

            Func<double, double, double> func3 = (a, b) => a / b;
            Console.WriteLine($"func3(22,7) : {func3(22, 7)}");
        }
    }
}
