// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using System;
using static System.Console;
Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine()!);
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 100);
PrintArray(array);
WriteLine();
array = changeArray(array);
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

void PrintArray (int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]}   ");
        }
        WriteLine();
    }
}

int [,] changeArray(int [,] array)
{
    int a = 0;
    for (int k = 0; k < array.GetLength(0); k++)
        {
            for (int l = 0; l < array.GetLength(1); l++)
            {
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    for (int j = i + 1; j < array.GetLength(1); j++)
                    {
                        if (array[k, i] < array[k, j])
                        {    
                            a = array[k, j];
                            array[k, j] = array[k, i];
                            array[k, i] = a;
                        }
                    }
                }
            }
        
        }
    return array;
}






