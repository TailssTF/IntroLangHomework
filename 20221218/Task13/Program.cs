/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

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
            Console.WriteLine("Ввели не число.");
        }
    }

    return result;
}

int number = GetNumber("Введите число");
if (number < 100)
    Console.WriteLine("третьей цифры нет");
else
{
    int temp = number;
    while(temp / 1000 != 0) temp/=10;
    Console.WriteLine(temp % 10);
}