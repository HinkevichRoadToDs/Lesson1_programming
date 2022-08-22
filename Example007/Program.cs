using System;

namespace Example007
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //Console.SetCursorPosition(10,4);
            //Console.WriteLine("+");

            int xa = 15, ya = 1;
            int xb = 1, yb = 10;
            int xc = 30, yc = 10;

            Console.SetCursorPosition(xa,ya);
            Console.WriteLine("+");
            Console.SetCursorPosition(xb,yb);
            Console.WriteLine("+");
            Console.SetCursorPosition(xc,yc);
            Console.WriteLine("+");

            int x = xa, y = ya; // x=15,y=1
            int count = 0;
            while(count < 10000)
            {
                int what = new Random().Next(0,3); // [0;3) 0 1 2
                if (what == 0)
                {
                    x = (x+xa)/2;//(15+15)/2=15
                    y = (y+ya)/2; //(1 + 1)/2=1  
                }
                if (what == 1)
                {
                    x = (x+xb) / 2;//(15+1)/2=8
                    y = (y + yb) / 2;//(1+10)/2=5
                }
                if (what == 2)
                {
                    x = (x + xc) / 2;
                    y = (y + yc) / 2;
                }
                Console.SetCursorPosition(x,y);
                Console.WriteLine("+");
                count = count + 1; // count++/count +=1;
            }
        }
    }
}
