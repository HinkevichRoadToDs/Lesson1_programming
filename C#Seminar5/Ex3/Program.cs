int size = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[size];

for (int i = 0; i < size; i++)
{
    
	Array[i] = new Random().Next(-9,10);
    Array[i]*=-1;
    
}
Console.WriteLine(string.Join(",",Array));
