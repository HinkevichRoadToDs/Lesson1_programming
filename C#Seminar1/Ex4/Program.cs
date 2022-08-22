using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        //{
        //Console.Write("Введите число ");
        //int number = Convert.ToInt32(Console.ReadLine());
        //int numberNeg = number * (-1);

        //while (numberNeg <= number )
        //{                
        //    Console.Write(numberNeg + " ");
        //    numberNeg = numberNeg++;// numberNeg + 1
        //}
        //}
        {
            Console.Write("Введите число ");
            int number = Convert.ToInt32(Console.ReadLine());
            int last_number = number;
            if (number >= 100 && number <= 999)
            {
                last_number = last_number % 10;
                Console.Write(last_number);
            }
            else
            {
                Console.Write("Ошибка");
            }
        }
    }
}
