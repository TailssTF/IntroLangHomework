/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
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

int x1 = GetNumber("Введите координату Х первой точки:");
int y1 = GetNumber("Введите координату Y первой точки:");
int z1 = GetNumber("Введите координату Z первой точки:");
int x2 = GetNumber("Введите координату Х второй точки:");
int y2 = GetNumber("Введите координату Y второй точки:");
int z2 = GetNumber("Введите координату Z первой точки:");

double GetDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1));
    return result;
}

double distance = GetDistance(x1, y1, z1, x2, y2, z2);

Console.WriteLine($"Расстояние равно {distance:0.00}");