// тип данных[] имя = {Значение1,Значение2} 
   int[] array = {11,21,31, 41, 15,61,17,18,19,31,15};

int size = array.Length; // размер массива
// число, которое нужно проверить, равно ли оно какому-либо элементу массива
int find = 31;
int find1 = 15;
int index = 0;

while ( index < size )
{
    if( array[index] == find )
    {
        Console.WriteLine(index);
        break;//если нужно прервать цикл при выполнении условия,
              //здесь мне нужнен одно число find найти
    }
    index++; // index = index + 1;
}

// немного по-другому попробовал
int index1 = 0;
while ( index1 < size && array[index1] != find1 )
{
    index1++;
}
Console.WriteLine(index1);







