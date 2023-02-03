/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
            result[i,j] = rnd.Next(leftBound, rightBound);
    }
    return result;
}

//Метод для печати массива
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

void SortRowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(1)-1-j; k++)
                if (array[i,k] < array[i,k+1])
                {
                    int temp = array[i,k];
                    array[i,k] = array[i,k+1];
                    array[i,k+1] = temp;
                }
    }
}

int rows = GetNumber("Введите количество строк массива");
int columns = GetNumber("Введите количество столбцов массива");
int[,] arr = InitArray(rows, columns, 0, 10);
PrintArray(arr);

SortRowArray(arr);
PrintArray(arr);