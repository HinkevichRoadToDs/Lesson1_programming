Console.WriteLine("Введите 1-ое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое число ");
int num2 = Convert.ToInt32(Console.ReadLine());

int sqr1 = num1*num1;//Math.Pow(num1, 2));
int sqr2 = num2*num2;//Math.Pow(num2, 2));

if (sqr1 == num2) Console.WriteLine("2-ое число является квадратом 1-ого");
if (sqr2 == num1) Console.WriteLine("1-ое число является квадратом 2-ого");