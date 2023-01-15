/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
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

int a = GetNumber("Введите число А");
int b = GetNumber("Введите число B");

int result = 1;

for (int i = 0; i < b; i++){
    result*= a;
}

Console.WriteLine($"Число {a} в {b} степени равно {result}");