Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double [rows,columns];
double sum = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
	for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(1,101);
        if(i  ==  j)
        {
            sum += matrix[i,j];
        }
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine($"Сумма элементов на главной диагонали = {sum}");
