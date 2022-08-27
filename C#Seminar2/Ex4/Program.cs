Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

int remain7 = num % 7;
int remain23 = num % 23;
if ( remain7 == 0 && remain23 == 0)
{
    Console.WriteLine(num + " кратно и 7 и 23");
}
else
{
    Console.WriteLine(num + " некратно обоим числам одновременно");
}


