/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/


int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Введено не число. Повторите ввод!");
        }
    }

    return result;
}

int number = GetNumber("Введите число");

int result = 0;

while (number / 10 >= 0 && number != 0){
    result += number % 10;
    number /= 10;
}

Console.WriteLine($"Сумма цифр в числе равна {result}");