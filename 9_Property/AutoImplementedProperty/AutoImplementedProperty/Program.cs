using System;

namespace AutoImplementedProperty
{
    class BirthdayInfo
    {
        public string Name { get; set; } = "Unknow";
        public DateTime BirthDay { get; set; } = new DateTime(1, 1, 1);

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
            BirthdayInfo birth = new BirthdayInfo();
            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"BirthDay : {birth.BirthDay.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");

            birth.Name = "서현";
            birth.BirthDay = new DateTime(1991, 6, 28);

            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"BirthDay : {birth.BirthDay.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");

        }
    }
   
}
