void FillArray(int[] collection)//метод
{
    int length = collection.Length;
    int index = 0;
    while (index <length)
    {
        collection[index] = new Random().Next(1,10);// через цикл заполняет масиив рандомными элеменами
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10]; // создай новый массив, в котором будет 10 элементов


FillArray(array);
PrintArray(array);