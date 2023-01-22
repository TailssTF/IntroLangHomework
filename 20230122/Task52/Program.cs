/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


// метод, который считывает с консоли (для размерности массива + границы случ. чисел)
int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
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

//метод для инициализации массива рандомными числами
int[,] InitArray(int row, int column, int leftBound, int rightBound)
{
    int[,] result = new int[row, column];
    Random rnd = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            result[i,j] = rnd.Next(leftBound, rightBound);
    }
    return result;
}

//метод для печати массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MeanByColumn(int[,] array)
{  
    int n = array.GetLength(0);
    int m = array.GetLength(1);
    for (int j = 0; j < m; j++)
    {
        double mean = 0;
        for (int i = 0; i < n ; i++)
            mean += array[i,j];
        mean/=n;
        Console.Write($"{mean:0.0} ");
    }
       
}


int rows = GetNumber("Введите количество строк массива");
int columns = GetNumber("Введите количество столбцов массива");
int[,] arr = InitArray(rows, columns, 0, 10);

PrintArray(arr);
Console.Write("Среднее арифметическое каждого столбца: ");
MeanByColumn(arr);
