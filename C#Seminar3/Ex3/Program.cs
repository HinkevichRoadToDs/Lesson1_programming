Console.Write("Введите A(x,y): x:");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write(" y:");
double ya = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите B(x,y): x:");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write(" y:");
double yb = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(xb-xa,2) + Math.Pow(yb-ya,2));
Console.WriteLine($"Расстояние равно {distance}");
