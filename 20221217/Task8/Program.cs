/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine() ?? "0");

if (n > 1)
{
    int count = 1;
    while (count <= n)
    {
        if (count % 2 == 0) Console.Write($"{count} ");
        count++;
    }
}
else Console.WriteLine("Неверный ввод");