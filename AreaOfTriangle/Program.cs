// По целочисленным координатам вершин треугольника (x1,y1), (x2,y2) и (x3,y3) требуется вычислить его площадь.

// Входные данные
// Входной файл INPUT.TXT содержит 6 целых чисел x1,y1,x2,y2,x3,y3 – координаты вершин треугольника. Все числа не превышают 106 по абсолютной величине.

// Выходные данные
// В выходной файл OUTPUT.TXT выведите точное значение площади заданного треугольника.

// Блок 1. Код для запуска в Visual Studio Code
internal class Program
{
    private static void Main(string[] args)
    {
        double SideOfTriangle(double x1, double y1, double x2, double y2)
        {
            return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 2);
        }

        double AreaOfTriangle(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2);
        }

        Console.Clear();
        Console.Write("Введите координаты точек x1,y1,x2,y2,x3,y3 через запятую: ");
        double[] array = Console.ReadLine()!.Split(',').Select(x => double.Parse(x)).ToArray();

        double a = SideOfTriangle(array[0], array[1], array[2], array[3]);
        double b = SideOfTriangle(array[0], array[1], array[4], array[5]);
        double c = SideOfTriangle(array[2], array[3], array[4], array[5]);
        Console.WriteLine($"Площадь треугольника: {AreaOfTriangle(a, b, c)}");
    }
}

// Блок 2. Код для запуска на сайте https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=6&id_topic=116&id_problem=719&ins=1#solution
// using System;
// using System.IO;
// using System.Linq;

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         double SideOfTriangle(double x1, double y1, double x2, double y2)
//         {
//             return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
//         }

//         double AreaOfTriangle(double a, double b, double c)
//         {
//             double p = (a + b + c) / 2;
//             return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
//         }
        
//         StreamReader sr = new StreamReader("input.txt");
//         StreamWriter sw = new StreamWriter("output.txt");
        
//         double[] array = Console.ReadLine().Split().Select(x => double.Parse(x)).ToArray();

//         double a1 = SideOfTriangle(array[0], array[1], array[2], array[3]);
//         double b1 = SideOfTriangle(array[0], array[1], array[4], array[5]);
//         double c1 = SideOfTriangle(array[2], array[3], array[4], array[5]);
//         string s = string.Format("{0:F1}", AreaOfTriangle(a1, b1, c1)).Replace(",", ".");
//         sw.WriteLine(s);
        
//         sw.Close();
//         sr.Close();
//     }
// }