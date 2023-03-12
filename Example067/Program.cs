// Напишите программу, которая будет принимать число и возвращать сумму его цифр
// 453 - > 12

using System;
using static System.Console;
Clear();

Write("Введите число: ");
int n = int.Parse(ReadLine());

//int sum = 0;
//while (n > 0)
//{
//    int num = n % 10;
//    n = n/10;
//    sum = sum + num;
//}
//WriteLine($"{sum}");

int GetSum(int number)
{
    if (number == 0)
        return 0;
    return (number % 10 + GetSum(number / 10));
}
WriteLine ($"{n}->{GetSum(n)}");