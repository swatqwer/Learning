using System;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как вас зовут?");
            String name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Привет, {name}! \nСегодня {DateTime.Now}");
            Console.ReadKey();
        }
    }
}