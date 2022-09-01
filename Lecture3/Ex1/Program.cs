// 2 Вид
void Method21(string msg, int count)
{
		int i = 0;
		while (i < count)
		{
				Console.WriteLine(msg);
				i++;
		}
}
Method21("Текст",4);

//3 Вид
int Method3()
{
	return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);


// Вид 4
string Method4(int count, string text)
{
	int i = 0;
	string result = String.Empty;
	while(i < count)
    {
		result = result + text;
		i++;
		
    }
	return result;
}
string res = Method4(4, "lol");
Console.WriteLine(res);