/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
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
            if (result < 1) Console.WriteLine("Число меньше 1");
            else break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}

void PrintN(int n)
{
    Console.Write($"{n}");
    if (n > 1) 
    {
        Console.Write($", ");
        PrintN(--n);
    }
}

int num = GetNumber("Введите N");
PrintN(num);