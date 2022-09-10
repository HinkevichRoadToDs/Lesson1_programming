double factorial(int n)
{
    //1! = 1
    //0! = 1
    if(n==1)return 1;
    else return n * factorial(n-1);
}

Console.WriteLine(factorial(3));

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {factorial(i)}");
}

