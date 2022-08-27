Console.WriteLine("Введите Х: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

if (X>0 && Y>0) Console.WriteLine("I четверть");
if (X<0 && Y>0) Console.WriteLine("II четверть");
if (X<0 && Y<0) Console.WriteLine("III четверть");
if (X>0 && Y<0) Console.WriteLine("IV четверть");
if (X==0 || Y==0) Console.WriteLine("не принадлежит к какой-либо четверти");