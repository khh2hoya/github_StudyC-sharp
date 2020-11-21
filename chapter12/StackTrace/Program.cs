using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTrace
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 1;
                Console.WriteLine(3 / --a);
            }
            catch( DivideByZeroException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
