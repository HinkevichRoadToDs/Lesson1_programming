using System;

namespace Example004__Div
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA = new Random().Next(1,10);
            Console.WriteLine(numberA); 
            int numberB = new Random().Next(1,10);
            Console.WriteLine(numberB);
            int result = 1 / 2;
            Console.WriteLine(result);

        }
    }
}
