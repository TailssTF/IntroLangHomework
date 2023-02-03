/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
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

int Akkerman(int n, int m)
{
    if (n == 0)
        return m+1;
    else
        if (n != 0 && m == 0)
            return Akkerman(n-1, 1);
    else
        return Akkerman(n-1, Akkerman(n, m-1));
}

int n = GetNumber("Введите N");
int m = GetNumber("Введите M");

Console.WriteLine(Akkerman(n, m));