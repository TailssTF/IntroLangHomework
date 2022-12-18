/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/


int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            if (result > 0 && result < 8)
                break;
            else
                Console.WriteLine("Эта цифра не обозначает день недели");
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }

    return result;
}

int number = GetNumber("Введите цифру, обозначающую день недели");

if (number == 6 || number == 7)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");