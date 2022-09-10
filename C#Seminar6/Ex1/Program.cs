int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i=0; i < size; i++)
    {
        res[i] = new Random().Next(minValue,maxValue+1);
    }
    return res;
}

void ReverseArray(int[] inArray)
{
    for(int i=0;i<inArray.Length/2;i++)
    {
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length-1-i];
        inArray[inArray.Length-1-i] = k;
    }
}

int[] array = GetArray(10,-5,5);
Console.WriteLine(String.Join(",",array));
ReverseArray(array);
Console.WriteLine("[{0}]",String.Join(",",array));

