// Выводит случайное число из отрезка и показывает наибольшую цифру числа
int num = new Random().Next(10,100); // инициализация переменной(сгенерирует от 10 до 99)
Console.WriteLine(num);

int num1 = num / 10;
int num2 = num % 10;

if (num1 < num2) Console.WriteLine(num2);
if (num2 < num1) Console.WriteLine(num1);
