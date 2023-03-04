// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1 7 -> такого числа в массиве нет

using System;
using static System.Console;
Clear();

Write("Введите номер строки массива: ");
int a1 = int.Parse(ReadLine());
Write("Введите номер столбца массива: ");
int b1 = int.Parse(ReadLine());

int[,] array = GetArray(4, 4);
PrintArray(array);
bool result = FindEl(array, a1, b1);
WriteLine(result);
bool FindEl(int[,] array, int a1, int b1)
{
    if (a1 < array.GetLength(0) || b1 < array.GetLength(1)) 
    {
        WriteLine($"Элемент с индексом [{a1},{b1}] - значение элемента равно {array[a1, b1]}");
        return true;
    }
    else 
    {
        WriteLine($"Элемент с индексом [{a1},{b1}] -> такого элемента нет в масииве");
        return false;
    }
}

int[,] GetArray(int minValue, int maxValue)
{
    int[,] result = new int[minValue,maxValue];
    for (int i = 0; i < minValue; i++)
    {
        for (int j = 0; j < maxValue; j++)
        {
            result[i, j] = new Random().Next(0, 100);
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
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}




