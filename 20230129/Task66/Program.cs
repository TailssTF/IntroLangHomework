/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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

int SumNtoM(int n, int m, int sum)
{
    int result = sum;
    if (n <= m)
    {
        sum+=n;
        result=(SumNtoM(++n, m, sum));
    }
        
    return result;
}

int n = GetNumber("Введите N");
int m = 0;
do 
{
    m = GetNumber("Введите M");
    if (m <= n) Console.WriteLine("M должно быть больше N");
}
while (m <= n);

Console.WriteLine(SumNtoM(n, m, 0));
