using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            // принимает на вход 2 числа и проверяет, является ли первое число квадратом второго
            Console.Write("Введите 1-ое число: ");
            int number0 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 2-ое число: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            if (number0 == Math.Pow(number1, 2)) // Math.Pow(number1, 2) = number1*number1
            {
                Console.WriteLine("1-ое число является квадратом второго");
            }
            else
            {
                Console.WriteLine("1-ое число не является квадратом второго");
            }
        }
    }
}
