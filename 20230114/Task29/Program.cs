/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]

все 8 элементов должны получить за один Console.ReadLine();
подсказка: использовать потом метод string.Split();
*/

int n = 8;

Console.WriteLine("Введите массив из 8 чисел через запятую:");
string strarray = Console.ReadLine();

string[] str = strarray.Split(',');

int[] arr = new int[n];

for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(str[i]);
}

for (int i = 0; i < n; i++)
{
    Console.Write($"{arr[i]} ");
}