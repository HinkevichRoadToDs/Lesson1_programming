using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //В зависимости от введенной цифры выводит день недели
            Console.Write("Введите число ");
            int numberDay = Convert.ToInt32(Console.ReadLine());
            if(numberDay >= 1 && numberDay <= 7) //конъюнкция
            { 
                if(numberDay==1)
                {
                    Console.WriteLine("Пн");
                }
                if(numberDay==2)
                {
                    Console.WriteLine("Вт");
                }
                if(numberDay==3)
                {
                    Console.WriteLine("Ср");
                }
                if(numberDay==4)
                {
                    Console.WriteLine("Чт");
                }
                if(numberDay==5)
                {
                    Console.WriteLine("Пт");
                }
                if(numberDay==6)
                {
                    Console.WriteLine("Сб");
                }
                if(numberDay==7)
                {
                    Console.WriteLine("Вс");
                }
            }
            else
            { 
                Console.WriteLine("Ошибка");
            }
        }
    }
}
