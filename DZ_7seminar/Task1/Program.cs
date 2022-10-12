// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using static System.Console;
using Lib;

Clear();
Write("Введите размерность массива 'm, n,минимальное число, максимальное число': ");
int[] intvalue = MyArray.GetArrayFromString(ReadLine());
double[,] matrix = CreateMatrix(intvalue[0], intvalue[1], intvalue[2], intvalue[3]);


if (intvalue.Length < 4 || intvalue.Length > 4)
{
    WriteLine("Пожалуйста введите 4 значения");
    return;
}

    double[,] CreateMatrix(int row, int column, int minValue, int maxValue)
    {
        double[,] resultArray = new double[row, column];
        Random rnd = new Random();
        double randomNum = new double();
        for (int i = 0; i < row ; i++)
        {
            for (int j = 0; j < column; j++)
            {
                randomNum = Math.Round(rnd.Next(minValue, maxValue)+rnd.NextDouble(),1);
                resultArray[i, j] = randomNum;
            }
        }
        return resultArray;
    }


MyArray.PrintMatrixDouble(matrix);
