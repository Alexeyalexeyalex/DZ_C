// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using static System.Console;
using Lib;

Clear();
int m = 1;
int n = 15;

WriteLine($"M = {m}; N = {n} -> {MyArray.SumBetweenMN(m,n)}");
