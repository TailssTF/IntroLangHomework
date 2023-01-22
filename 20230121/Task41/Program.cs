/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
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

/*
//метод для инициализации массива рандомными числами
int[] InitArray(int dimension, int leftBound, int rightBound)
{
    int[] result = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        result[i] = rnd.Next(leftBound, rightBound);
    }
    return result;
}
*/

int[] ReadArray(int n)
{
    int[] result = new int[n];
    for (int i = 0; i < n; i++)
        result[i] = GetNumber("");
    return result;
}

//метод для печати массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int SumPositive(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) result += array[i];
    return result;
}

int number = GetNumber("Введите размер массива");
Console.WriteLine("Введите элементы массива");
int[] arr = ReadArray(number);
PrintArray(arr);
Console.WriteLine($"Сумма положительных элементов равна {SumPositive(arr)}");
