using System;

namespace Example006
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 13;
            int b = 3;
            int c = 7;
            int d = 3;
            int e = 12;

            int max_number = a;

            if (b > max_number) max_number = b;
            if (c > max_number) max_number = c;
            if (d > max_number) max_number = d;
            if (e > max_number) max_number = e;
            
            Console.WriteLine(max_number);
        }
    }
}
