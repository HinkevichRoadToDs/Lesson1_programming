using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Программа, выводящая квадрат числа
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            int sqr = number*number;
            Console.Write(sqr);
          // Комментарий
        }
    }
}
