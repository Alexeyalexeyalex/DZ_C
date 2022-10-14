// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


using static System.Console;
using Lib;

Clear();
int row = 4, column = 4, minValue = 1, maxValue = 9;
int[,]  firstMatrix = MyArray.CreateMatrix(row,column,minValue,maxValue),
        secondMatrix = MyArray.CreateMatrix(row,column,minValue,maxValue);


MyArray.PrintMatrix(firstMatrix);
WriteLine();
MyArray.PrintMatrix(secondMatrix);
