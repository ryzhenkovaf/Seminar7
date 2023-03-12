// **Задача 65:**Задайте значения M и N.
// Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N.

using System;
using static System.Console;
Clear();

Write("Введите Start: ");
int n = int.Parse(ReadLine());
Write("Введите End: ");
int m = int.Parse(ReadLine());
 WriteLine(PrintNumbers(n, m));
//for (int i = m; i <= n; i++)
//{
//    Write($"{i} ");
//}
 string PrintNumbers(int start, int end)
 {
    if (end == start)
    {
        return start.ToString();
    }
    string s = PrintNumbers(start, end - 1) + ' ' + end.ToString();
    return s;
 }

