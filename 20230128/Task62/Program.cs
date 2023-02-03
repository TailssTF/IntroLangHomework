/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] FillSpiral(int size)
{
    int num = 1;
    int cycle = 0;
    int i = 0, j = 0;
    int[,] result = new int[size,size];
    
    while (num <= size*size)
    {
        result[i,j] = num;
        if (i == cycle && j < size - cycle - 1) 
            j++;
        else if (j == size - cycle - 1 && i < size - cycle - 1) 
            i++;
        else if (i == size - cycle - 1 && j > cycle)
            j--;
        else
            i--;
        
        if (i == cycle + 1 
            && j == cycle 
            && cycle != size - cycle - 1) 
                cycle++;
        num++;
    }
    return result;
}

//Метод для печати массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i,j] < 10) Console.Write($"0{array[i, j]} ");
            else    Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int n = 4;
int[,] arr = FillSpiral(n);
PrintArray(arr);