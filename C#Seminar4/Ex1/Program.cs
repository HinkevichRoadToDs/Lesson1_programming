Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма = " + GetSum(num));
int GetSum (int number)
{
    int sum = 0;
    int count = 0;

    while (count < number)
    {
        count++;
        sum+=count;
    }
    return sum;
}

