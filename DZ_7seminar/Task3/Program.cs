// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using static System.Console;
using Lib;

Clear();
int[,] matrix = MyArray.CreateMatrix(3, 4, 1, 9);
MyArray.PrintMatrix(matrix);
WriteLine();
WriteLine(string.Join(" ", averageColumn(matrix)));



double[] averageColumn(int[,] matrix)
{
    double[] result = new double[matrix.GetLength(1)];
    double count = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            result[i] += matrix[j, i];
            count++;
        }
        result[i] = Math.Round(result[i] / count, 1);
        count = 0;
    }
    return result;
}