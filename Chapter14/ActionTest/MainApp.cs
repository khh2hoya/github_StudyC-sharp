using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionTest
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Action act1 = () => Console.WriteLine("Action()");
            act1();

            int result = 0;
            Action<int> act2 = (a) => result = a * a;
            act2(8);
            Console.WriteLine($"result = {result}");

            Action<double, double> act3 = (a, b) =>
             {
                 double pi = a / b;
                 Console.WriteLine($"Action<T1, T2>({a} , {b} )");
             };

            act3(22.0,7);



        }
    }
}
