using System;

namespace ThisConstructor2
{
    class MyClass
    {
        int a, b, c;

        public MyClass()
        {
            this.a = 5452;

            Console.WriteLine("MyClass");
        }

        public MyClass(int b) : this()
        {
            this.b = b;
            Console.WriteLine($"MyClass({b})");
        }

        public MyClass(int b, int c) : this(b)
        {
            this.c = c;
            Console.WriteLine($"MyClass({b} , {c})");
        }

        public void PrintFields()
        {
            Console.WriteLine($"a:{a} , b : {b} , c : {c}");
        }

        

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass();
            a.PrintFields();

            MyClass b = new MyClass(10);
            b.PrintFields();

            MyClass c = new MyClass(1, 2);
            c.PrintFields();

            Console.WriteLine("Hello World!");
        }
    }
}
