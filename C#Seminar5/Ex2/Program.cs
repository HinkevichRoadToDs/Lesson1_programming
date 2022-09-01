int[] inputArray = {1,2,3,4,5};
int size = inputArray.Length;

int [] resultArray = new int[inputArray.Length/2 + inputArray.Length%2];

for(int i = 0; i < inputArray.Length/2 + inputArray.Length%2;i++)
{
    resultArray[i] = inputArray[i] * inputArray[size-1-i];
    if(i == (size - 1 - i))
    {
        resultArray[i]=inputArray[i];
    }
}
Console.WriteLine(string.Join(",",resultArray));
