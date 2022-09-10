using System.Linq; // подключение системной библиотеки
// хочу разобраться, как узнать тип переменной 
int a = 12;
Console.WriteLine(a.GetType());
Console.WriteLine(a.GetType().Name);

var b = 12;
Console.WriteLine(b.GetType().Name);

var data = new int[]{1,2,3,4}
        .Where(e => e>0)
        .Select(e=> new {q = e, w = e + 1});
Console.WriteLine(data.GetType().Name);