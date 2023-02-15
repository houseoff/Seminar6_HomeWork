// Дана строка, состоящая из N попарно различных символов. Требуется вывести все перестановки символов данной строки.

// Входные данные
// Входной файл INPUT.TXT содержит строку, состоящую из N символов (1 ≤ N ≤ 8), символы - буквы английского алфавита и цифры.

// Выходные данные
// В выходной файл OUTPUT.TXT выведите в каждой строке по одной перестановке. Перестановки можно выводить в любом порядке. 
// Повторений и строк, не являющихся перестановками исходной, быть не должно

// Блок 1. Код для запуска в Visual Studio Code
using System;
internal class Program
{
     private static void Main(string[] args)
     {
        
        void Permutations(char[] array, int pos)
        {
            if (pos == array.Length)
                Console.WriteLine(string.Join("", array));
            for (int i = pos; i < array.Length; i++)
            {
                char t = array[i];
                array[i] = array[pos];
                array[pos] = t;
                Permutations(array, pos + 1);
                t = array[i];
                array[i] = array[pos];
                array[pos] = t;
            }
        }
        
        Console.Clear();
        Console.Write("Введите строку: ");
        string s = Console.ReadLine()!;
        char[] array = s.ToCharArray();
        Permutations(array, 0);
    }
}

// Блок 2. Код для запуска на сайте https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=9&id_topic=123&id_problem=765
// using System;
// using System.IO;

// internal class Program
// {
//     private static void Main(string[] args)
//     {
        
//         void Permutations(char[] a, int pos, StreamWriter sw)
//         {
//             if (pos == a.Length)
//                 sw.WriteLine(string.Join("", a));
//             for (int i = pos; i < a.Length; i++)
//             {
//                 char t = a[i];
//                 a[i] = a[pos];
//                 a[pos] = t;
//                 Permutations(a, pos + 1, sw);
//                 t = a[i];
//                 a[i] = a[pos];
//                 a[pos] = t;
//             }
//         }
        
//         StreamReader sr = new StreamReader("input.txt");
//         StreamWriter swriter = new StreamWriter("output.txt");
        
//         string s = sr.ReadLine();
//         char[] array = s.ToCharArray();
//         Permutations(array, 0, swriter);
        
//         sr.Close();
//         swriter.Close();
//     }
// }