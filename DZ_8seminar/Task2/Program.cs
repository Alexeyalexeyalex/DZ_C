// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

using static System.Console;
using Lib;

Clear();
int row = 4, column = 4, minValue = 1, maxValue = 9;
int[,] myMatrix = MyArray.CreateMatrix(row,column,minValue,maxValue);

MyArray.PrintMatrix(myMatrix);
WriteLine();
MyArray.MinSumRowInMatrix(myMatrix);
