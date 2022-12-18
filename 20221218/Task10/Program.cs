/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/


int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            if (result > 99 && result < 1000)
                break;
            else
                Console.WriteLine("Число не трехзначное");
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }

    return result;
}

int number = GetNumber("Введите трехзначное число");

int result = number / 10 % 10;

Console.WriteLine(result);