// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


using static System.Console;
using Lib;

Clear();
int row = 4, column = 4, minValue = 1, maxValue = 9;
int[,] myMatrix = MyArray.CreateMatrix(row,column,minValue,maxValue);

MyArray.PrintMatrix(myMatrix);
WriteLine();
MyArray.PrintMatrix(MyArray.SortMatrixRow(myMatrix));
