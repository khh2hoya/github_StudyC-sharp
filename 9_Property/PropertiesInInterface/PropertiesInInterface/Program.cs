using System;

namespace PropertiesInInterface
{
    interface INamedValue
    {
        string Name
        {
            get; set;
        }

        string value
        {
            get; set;
        }
    }

    class NamedValue : INamedValue
    {
        public string Name
        {
            get; set;
        }

        public string value
        {
            get; set;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NamedValue name = new NamedValue()
            { Name = "이름", value = "박상현" };

            NamedValue height = new NamedValue()
            { Name = "키", value = "180cm" };

            NamedValue weight = new NamedValue()
            { Name = "몸무게", value = "74kg" };

            Console.WriteLine($"{name.Name} : {name.value}");
            Console.WriteLine($"{height.Name} : {height.value}");
            Console.WriteLine($"{weight.Name} : {weight.value}");

        
        }
    }
}
