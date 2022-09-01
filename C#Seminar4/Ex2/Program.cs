Console.WriteLine("Число: ");
int num = Convert.ToInt32(Console.ReadLine());
string Stringnum = Convert.ToString(num);

int GetLength(string number)
{
    int numLength = number.Length;
    return numLength;
}
Console.WriteLine($"Длина {GetLength(Stringnum)}");
