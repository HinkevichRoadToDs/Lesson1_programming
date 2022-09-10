Console.Write("Введите число n ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];
array[0] = 0;
array[1] = 1;
void Fibonacci(int[] arr)
{
    for (int i = 2; i < number-1; i++)
    {
        array[i+1]=array[i]+array[i-1];
        Console.Write(" " + array[i+1]);
    }
}
Fibonacci(array);


