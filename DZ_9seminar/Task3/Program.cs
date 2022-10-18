// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using static System.Console;
using Lib;

Clear();
int m = 3;
int n = 2;
if (m >= 0 && n >= 0)
{
    WriteLine($"M = {m}; N = {n} -> {MyArray.AkermanMN(m, n)}");
}