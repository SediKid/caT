using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat("Петя", new DateTime(2007, 7, 13));
            c.MakeNoise();
            Console.WriteLine($"Коту {c.Name} уже {c.GetAge()} лет");
        }
    }

}
