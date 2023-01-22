/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
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
double[,] InitArray(int row, int column)
{
    double[,] result = new double[row, column];
    Random rnd = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            result[i,j] = rnd.NextDouble();
    }
    return result;
}

//метод для печати массива
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j]:0.0} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int rows = GetNumber("Введите количество строк массива");
int columns = GetNumber("Введите количество столбцов массива");
double[,] arr = InitArray(rows, columns);

PrintArray(arr);
