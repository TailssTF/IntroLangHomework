/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result >= 10000 && result < 100000)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не пятизначное число.");
        }
    }

    return result;
}

int number = GetNumber("Введите пятизначное число");

if (number / 10000 % 10 == number % 10 && number / 1000 % 10 == number / 10 % 10)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");