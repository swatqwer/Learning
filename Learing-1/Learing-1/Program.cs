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
            Console.WriteLine($"Привет, {name}! \nСегодня: {DateTime.Now.ToString("dd.MM.yyyy")} \nВремя: {DateTime.Now.ToString("HH:mm:ss")}");
            Console.ReadKey();
        }
    }
}