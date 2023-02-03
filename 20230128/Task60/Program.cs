/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
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

//проверка на уникальность
bool IsNew(int num, int[,,] array, int x, int y, int z)
{
    int size = array.GetLength(0);
    bool newnum = true;
    for (int i = 0; i < size; i++)
        for (int j = 0; j < size; j++)
            for (int k = 0; k < size; k++)    
                if (i == x && j == y && k == z) continue;
                else if (array[i,j,k] == num) newnum = false;
    return newnum;
}

//Метод инициализации трехмерного массива случайными уникальными числами
int[,,] InitArray(int size, int leftBound, int rightBound)
{
    int[,,] result = new int[size, size, size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
        for (int j = 0; j < size; j++)
            for (int k = 0; k < size; k++)
                do
                    result[i, j, k] = rnd.Next(leftBound, rightBound);
                while (!IsNew(result[i,j,k], result, i, j, k));
    return result;
}

//Метод для печати массива
void PrintArray(int[,,] array)
{
    int size = array.GetLength(0);
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            for (int k = 0; k < size; k++)
                Console.Write($"{array[j, k, i]}({j},{k},{i}) ");
            Console.WriteLine();
        }

    }
    Console.WriteLine();
}


int size = GetNumber("Введите размер квадратной матрицы");
int[,,] arr1 = InitArray(size, 10, 100);
PrintArray(arr1);
