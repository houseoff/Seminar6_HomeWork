// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int CountOfPositiveNumbers(int[] a)
{
    int count = 0;
    foreach (int e in a)
    {
        if (e > 0)
            count++;
    }
    return count;
}

Console.Clear();
Console.Write("Введите числа через запятую: ");
int[] array = Console.ReadLine()!.Split(',').Select(x => int.Parse(x)).ToArray();

Console.WriteLine($"Кол-во положительных чисел: {CountOfPositiveNumbers(array)}");