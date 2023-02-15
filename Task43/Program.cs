// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double FindX(double k1, double b1, double k2, double b2)
{
    return (b2 - b1) / (k2 - k1);
}

double FindY(double x, double k, double b)
{
    return k * x + b;
}

Console.Clear();
Console.WriteLine("Введите числа k1,b1,k2,b2 через запятую: ");
double[] array = Console.ReadLine()!.Split(',').Select(x => double.Parse(x)).ToArray();

if (array[0] == array[2])
    Console.WriteLine("Прямые параллельны");
else if (array[0] == array[2] & array[1] == array[3])
    Console.WriteLine("Прямые наложены друг на друга");
else
{
    double x = FindX(array[0], array[1], array[2], array[3]);
    double y = FindY(x, array[0], array[1]);
    Console.WriteLine($"Точка пересечения: [{x}, {y}]");
}