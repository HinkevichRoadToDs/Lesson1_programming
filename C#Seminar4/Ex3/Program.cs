Console.Write("Число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма произведений = {GetProduct(num)}");

int GetProduct(int num)
{
	int prod = 1;
    for (int count = 1; count <= num; count++)
		{
			prod *= count;  
		}
	return prod;  
}

