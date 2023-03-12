// **Задача 63:**Задайте значение N.Напишите программу,
// которая выведет все натуральные числа в промежутке от 1 до N.


using System;
using static System.Console;

Clear();
Write("Введите N: ");
int n=int.Parse(ReadLine());
for (int i = 1; i <= n; i++){
    Write($"{i} ");
}
WriteLine();
WriteLine(PrintNumbers(n));

string PrintNumbers(int n){
    if (n == 1)
    {
        WriteLine(1);
        return "1";
    }
    string s = PrintNumbers(n - 1) + " " + n.ToString();
    WriteLine(s);
    return s;
}