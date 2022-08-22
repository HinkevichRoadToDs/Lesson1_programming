//Поиск максимального из 9 чисел

// запись функции, ищущей максимум из трех чисел;
int Max(int arg1,int arg2, int arg3)
{
    int result = arg1;
    if( arg2>result) result = arg2; 
    if( arg3>result) result = arg3;
    return result;
}

int a1= 17;
int b1= 13;
int c1= 11;
int a2= 43;
int b2= 23;
int c2= 111;
int a3= 43;
int b3= 65;
int c3= 23;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
// int max = Max(Max(a1, b1, c1),Max(a2, b2, c2),Max(a3, b3, c3));


Console.WriteLine(max);

