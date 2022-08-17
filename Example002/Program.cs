using System;

namespace Example002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя");
            string username = Console.ReadLine();
            Console.Write("Привет, ");
            Console.Write(username);
        }
    }
}
