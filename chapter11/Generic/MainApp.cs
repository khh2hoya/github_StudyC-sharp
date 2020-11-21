using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class MainApp
    {
        class MyList<T>
        {
            private T[] array;

            public MyList()
            {
                array = new T[3];
            }

            public T this[int index]
            {
                get
                {
                    return array[index];
                }

                set
                {
                    if(index >= array.Length)
                    {
                       
                        Array.Resize<T>(ref array, index + 1);
                        Console.WriteLine($"Array Resized : {array.Length}");
                    }
                }
            }

            public int Length
            {
                get { return array.Length; }
            }
        }
        static void Main(string[] args)
        {

            MyList<string> str_list = new MyList<string>();
            str_list[0] = "abc";
            str_list[0] = "def";
            str_list[0] = "ghi";
            str_list[0] = "jkl";
            str_list[0] = "mno";

            for( int i = 0; i < str_list.Length; i++    )
            {
                Console.WriteLine(str_list[i]);
            }

            MyList<int> int_list = new MyList<int>();
            for(int i = 0; i < 5; i++ )
            {
                int_list[i] = i;

                Console.WriteLine(int_list[i]);
            }
            
        }
    }
}
