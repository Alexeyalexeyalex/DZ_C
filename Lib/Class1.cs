using System;
using static System.Console;

namespace Lib;
public class MyArray
{
    ///<summary>
    ///Создание массива со случайными числами
    ///<summary>
    public static int[] CreateRandomArray(int size, int minValue, int maxValue)
    {
        int[] resultArray = new int[size];
        Random rnd = new Random();
        for (int i = 0; i < size; i++)
        {
            resultArray[i] = rnd.Next(minValue, maxValue + 1);
        }
        return resultArray;
    }

    ///<summary>
    ///Создание матрицы со случайными числами
    ///<summary>
    public static int[,] CreateMatrix(int row, int column, int minValue, int maxValue)
    {
        int[,] resultArray = new int[row, column];
        Random rnd = new Random();
        for (int i = 0; i < row ; i++)
        {
            for (int j = 0; j < column; j++)
            {
                resultArray[i, j] = rnd.Next(minValue, maxValue + 1);
            }
        }
        return resultArray;
    }

    ///<summary>
    ///Печать массива int
    ///<summary>
    public static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Write($"{matrix[i,j]} ");
            }
            WriteLine();
        }
    }
    ///<summary>
    ///Печать массива double
    ///<summary>
    public static void PrintMatrixDouble(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Write($"{matrix[i,j]} ");
            }
            WriteLine();
        }
    }
    public static int[] GetArrayFromString(string inputValue)
    {
        string[] stringValue = inputValue.Split(" ",StringSplitOptions.RemoveEmptyEntries);
        int[] intValue = new int[stringValue.Length];
        for (int i = 0; i < intValue.Length; i++)
        {
            intValue[i] = int.Parse(stringValue[i]);
        }
        return intValue;
    }
}
