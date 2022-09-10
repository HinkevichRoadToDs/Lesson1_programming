int rows = int.Parse(Console.ReadLine());// конвертация в int (int.Parse)

int columns =Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int [rows,columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
	for (int j = 0; j < matrix.GetLength(1); j++)
	{
		matrix[i,j] = new Random().Next(-100,101);
		Console.Write(matrix[i,j] + "\t"); //литералы( позволяет сделать промежуток между элементами)
	}
	Console.WriteLine();
}