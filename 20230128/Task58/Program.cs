/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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
int[,] InitArray(int size, int leftBound, int rightBound)
{
    int[,] result = new int[size, size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
            result[i, j] = rnd.Next(leftBound, rightBound);
    }
    return result;
}

//Метод для печати массива
void PrintArray(int[,] array)
{
    int size = array.GetLength(0);
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int MultRowCol(int row, int col, int[,] array1, int[,] array2)
{
    int size = array1.GetLength(0);
    int result = 0;
    for (int i = 0; i < size; i++)
        result+=array1[row,i]*array2[i,col];
    return result;
}

int[,] MultMatrix(int[,] array1, int[,] array2)
{
    int size = array1.GetLength(0);
    int[,] result = new int[size,size];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
            result[i,j] = MultRowCol(i, j, array1, array2);
    }
    return result;
}

int size = GetNumber("Введите размер квадратной матрицы");
int[,] arr1 = InitArray(size, 1, 10);
PrintArray(arr1);
int[,] arr2 = InitArray(size, 1, 10);
PrintArray(arr2);

int[,] arr3 = MultMatrix(arr1, arr2);
PrintArray(arr3);