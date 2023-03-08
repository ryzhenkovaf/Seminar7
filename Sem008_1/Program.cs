// Написать программу, которая обменивает элементы первой строки и последней строки

using System;
using static System.Console;
Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine()!);
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine();
array = changeLines(array);
PrintArray(array);


int[,] GetArray (int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

int[,] changeLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int d = 0;
        d = array[0, i];
        array[0, i] = array[(array.GetLength(0)-1), i];
        array[(array.GetLength(0)-1), i] = d;
    }
    return array;
}
void PrintArray (int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}


