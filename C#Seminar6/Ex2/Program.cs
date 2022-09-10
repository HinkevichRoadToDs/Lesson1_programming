Console.WriteLine("Введите стороны треугольника(a,b,c): ");
double number1 = Convert.ToDouble(Console.ReadLine());
double number2 = Convert.ToDouble(Console.ReadLine());
double number3 = Convert.ToDouble(Console.ReadLine());


void CheckTriangle(double a,double b,double c)
{
    if( a < b + c && b < c + a && c < a + b)
    {
        Console.WriteLine("треугольник со сторонами такой длины может существовать.");
    }
    else
    {
        Console.WriteLine("такой треугольник не существует");
    }
}
CheckTriangle(number1,number2,number3);

