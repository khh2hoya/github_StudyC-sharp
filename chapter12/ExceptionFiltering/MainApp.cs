using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionFiltering
{
    class FilterableException : Exception
    {
        public int ErrorNum { get; set; }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number Between 0 ~ 10");
            string input = Console.ReadLine();

            try
            {
                int num = Int32.Parse(input);

                if (num < 0 || num > 10)
                    throw new FilterableException() { ErrorNum = num };
                else
                    Console.WriteLine($"Output : { num}");
            }
            catch( FilterableException e) when (e.ErrorNum < 0 )
            {
                Console.WriteLine("Negative input is not allowed");
            }
            catch( FilterableException e) when ( e.ErrorNum > 10 )
            {
                Console.WriteLine("Too big number is not allowed ");
            }
        }
    }
}
