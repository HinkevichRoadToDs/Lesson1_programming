Console.Write("Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

for (int i = 0; i < size; i++)
	{
	array[i] = new Random().Next(-9,10);
	}

Console.WriteLine("[{0}]",String.Join(";",array));

Console.Write("Введите искомое число ");
int necessaryNumber = Convert.ToInt32(Console.ReadLine());

int count = 0;
for (int i = 0; i < size; i++)
	{
		if(array[i] == necessaryNumber)
		{
			count++;
		}
	}
if (count > 0) 
	{
	Console.WriteLine($"Это число найдено в количестве: {count}");
	}
else
{
	Console.WriteLine("Число не найдено");
}

