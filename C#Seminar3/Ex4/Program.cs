Console.Write("Введите N: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];
int index = 0;
int number1 = 1;
int number2 = 0;

while(number1 <= number)
{
    number2 = number1*number1;
    array[index]= number2;
    Console.Write(array[index] + " ");
    number1++;
    index++;
}

//Console.WriteLine(array);// но так не очень корректно выводится 