// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

using static System.Console;
using Lib;

Clear();
Write("Введите позицию элемента массива 'строка столбец': ");
int[] intvalue = MyArray.GetArrayFromString(ReadLine());
int[,] matrix = MyArray.CreateMatrix(3, 4, 1, 9);
MyArray.PrintMatrix(matrix);

if (intvalue.Length < 2 || intvalue.Length > 2)
{
    WriteLine("Пожалуйста введите 2 значения");
    return;
}
if (intvalue[0] <= matrix.GetLength(0) && intvalue[1] <= matrix.GetLength(1))
{
    WriteLine($"{matrix[intvalue[0], intvalue[1]]}");
}
else WriteLine("Нет такой позиции");

