using System;

namespace ConstructorWithProperty
{ 
    class BirthdayInfo
    {
        public string Name
        {
            get; set;
        }

        public DateTime BirthDay
        {
            get; set;
        }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(BirthDay).Ticks).Year;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo()
            {
                Name = "서현",
                BirthDay = new DateTime(1991, 6, 28)
            };

            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.BirthDay.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");

        }
    }
}
