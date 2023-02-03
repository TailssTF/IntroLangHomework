/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/


//Метод считывания числа с клавиатуры
int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}


//Метод инициализации двумерного массива случайными числами
int[,] InitArray(int row, int column, int leftBound, int rightBound)
{
    int[,] result = new int[row, column];
    Random rnd = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            result[i, j] = rnd.Next(leftBound, rightBound);
    }
    return result;
}

//Метод для печати массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int FindMinSum(int[,] array)
{
    int result = 0;
    int minsum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];
        if (minsum == 0) minsum = sum;
        if (sum < minsum) 
        {
            minsum = sum;
            result = i;
        }
    }
    return result;
}

int rows = GetNumber("Введите количество строк массива");
int columns = GetNumber("Введите количество столбцов массива");
int[,] arr = InitArray(rows, columns, 0, 10);
PrintArray(arr);

Console.WriteLine(FindMinSum(arr));