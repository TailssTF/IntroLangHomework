/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите три числа");
int a = int.Parse(Console.ReadLine() ?? "0");
int b = int.Parse(Console.ReadLine() ?? "0");
int c = int.Parse(Console.ReadLine() ?? "0");

int max = a;

if (b > max) 
    max = b; 
if (c > max)
    max = c;
Console.WriteLine($"Большее число: {max}");