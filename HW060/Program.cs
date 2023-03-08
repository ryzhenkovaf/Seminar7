﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

using System;
using static System.Console;
Clear();

int[,,] array3d = new int[2, 2, 2];
GetArray3d(array3d);
Write("Трехмерный массив с индексами элементов: ");
WriteLine();
PrintArray3d(array3d);

void PrintArray3d(int[,,] arr)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            WriteLine();
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                Write($"{array3d[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

void GetArray3d(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 3;
            }
        }
    }
}