//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int num = new Random().Next(100,1000); 
Console.WriteLine(num);

int num1 = num / 100;
int num2 = num % 10;

Console.WriteLine(num1 + "" + num2);

Console.WriteLine(num1 * 10 + num2);