int rows = int.Parse(Console.ReadLine());
int columns =Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double [rows,columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
	for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = i + j;
        if(i % 2 == 0 && j % 2 == 0)
        {
            matrix[i,j] = Math.Pow(matrix[i,j],2);
        }
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}


