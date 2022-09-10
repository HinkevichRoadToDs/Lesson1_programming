Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());



void ToBinary(int n)
{ 
    string binaryNum = string.Empty;
    while (n > 0)
    {
        binaryNum = n%2 + binaryNum;
        n/=2;
    }
    Console.WriteLine(binaryNum);
}
ToBinary(number);

string str = 4 + "4";
Console.WriteLine(str);// выведет 44(string)