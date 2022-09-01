
int [] array = new int [12];
int size = array.Length;

int positiveSum = 0;
int negativeSum = 0;

for (int i = 0; i < size; i++)
			{
				array[i] = new Random().Next(-9,10);
				if (array[i] > 0)
				{
					positiveSum += array[i];
				}
				if (array[i] < 0)
				{
					negativeSum += array[i];
				}
				Console.Write(array[i] + " ");
			}
Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел = {positiveSum}");
Console.WriteLine($"Сумма отрицательных чисел = {negativeSum}");
Console.WriteLine(String.Join(";",array));
