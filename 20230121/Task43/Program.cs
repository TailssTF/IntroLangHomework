/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
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

void Cross (int k1, int b1, int k2, int b2)
{
    double temp1 = (b1 - b2);
    double temp2 = (k1 - k2)*-1;
    double x = temp1 / temp2;
    double y = k1 * x + b1;
    
    Console.WriteLine($"({x}; {y})");
}

int k1 = GetNumber("Введите k1");
int b1 = GetNumber("Введите b1");
int k2 = GetNumber("Введите k2");
int b2 = GetNumber("Введите b2");
Cross(k1, b1, k2, b2);


