/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
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

int FindByIndex(int[,] array, int pos)
{  
    int n = array.GetLength(0);
    int m = array.GetLength(1);
    if (pos > 0 && pos < n * m)
    {
        int row = 0;
        int col = 0;
        while (pos - n >= 0)
        {
            row++;
            pos-=n;
        }
        col = pos;
        return array[row-1,col-1];
    }
    else
        return -1;
       
}


int rows = GetNumber("Введите количество строк массива");
int columns = GetNumber("Введите количество столбцов массива");
int[,] arr = InitArray(rows, columns, 0, 10);

PrintArray(arr);
int position = GetNumber("Введите позицию элеменета");
int result = FindByIndex(arr, position);
if (result > 0) 
    Console.WriteLine(result);
else
    Console.WriteLine("Такого числа в массиве нет");
