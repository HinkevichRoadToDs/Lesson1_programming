int[] arr = {2,1,5,3,1,4,9,6,7,8,2};

void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int index = 0; index < array.Length - 1; index++)
	{
        int minPosition=index;
        for (int j = index + 1; j < array.Length; j++)
		{
            if(array[j] < array[minPosition]) minPosition = j;
		}
        int temporary = array[index];
        array[index]= array[minPosition];
        array[minPosition] = temporary;
	}
}
SelectionSort(arr);
PrintArray(arr);
