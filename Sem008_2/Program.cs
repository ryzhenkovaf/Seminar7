// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, 
// что это невозможно (в случае, если матрица не квадратная).

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
array = changeLinesToColumns(array);
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

int[,] changeLinesToColumns(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            int a = array[i, j];
            array[i, j] = array [j, i];
            array[j, i] = a;
        }
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

//bool arr (int[,] array, int rows, int columns)
//{
//    if (rows == array.GetLength(1) && columns == array.GetLength(0))
//    {
//        return true;
//    }
//    else
//    {
//        WriteLine("Матрица не квадратная");
//    }
//}
//bool result = arr(array, rows, columns);
//WriteLine(result);
