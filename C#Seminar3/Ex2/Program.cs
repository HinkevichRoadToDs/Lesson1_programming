Console.WriteLine("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 4)
{
    if (number == 1) Console.WriteLine("X(0,infin);Y(0,infin)");
    if (number == 2) Console.WriteLine("X(-infin,0),Y(0,infin)");
    if (number == 3) Console.WriteLine("X(-infin,0),Y(-infin,0)");
    if (number == 4) Console.WriteLine("X(0,infin),Y(-infin,0)");
}
else
{
    Console.WriteLine("Введите число от 1 до 4");
}