Console.WriteLine("Введите 1-ое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое число ");
int num2 = Convert.ToInt32(Console.ReadLine());
int remain = num1 % num2;
if (remain == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.Write("некратно, ");
    Console.Write(remain);
}
