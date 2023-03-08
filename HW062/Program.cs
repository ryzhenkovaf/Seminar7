// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

using System;
using static System.Console;
Clear();

int size = 4;
int[,] array = new int[size, size];
GetArray(array, size);
Write("Массив 4х4: ");
WriteLine();
WriteLine();
PrintArray(array);

void GetArray(int[,] array, int n)
{
    int i = 0;
    int j = 0;
    int number = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = number++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = number++;
        for (k = 0; k < n - 1; k++) array[i, j--] = number++;
        for (k = 0; k < n - 1; k++) array[i--, j] = number++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

//  Функция вывода двумерного массива в терминал
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] < 10)
            {
                Write("0" + inArray[i, j]);
                Write(" ");
            }
            else 
            {
                Write(inArray[i, j] + " ");
            }
        }
        WriteLine();
    }
}
