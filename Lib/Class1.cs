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
        for (int i = 0; i < row; i++)
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
                Write($"{matrix[i, j]} ");
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
                Write($"{matrix[i, j]} ");
            }
            WriteLine();
        }
    }
    public static int[] GetArrayFromString(string inputValue)
    {
        string[] stringValue = inputValue.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        int[] intValue = new int[stringValue.Length];
        for (int i = 0; i < intValue.Length; i++)
        {
            intValue[i] = int.Parse(stringValue[i]);
        }
        return intValue;
    }

    ///<summary>
    ///Создает спиральную матрицу
    ///<summary>
    public static int[,] CreateSpiralMatrix(int row, int column)
    {
        int[,] result = new int[row, column];
        int num = 1, i = 0, j = 0, m = 1;
        string n = string.Empty;
        result[0, 0] = num;
        while (m != row * column)
        {
            while (n != "Right")
            {
                if (j < column - 1 && result[i, j + 1] == 0)
                {
                    j++;
                    num++;
                    if (result[i, j] == 0)

                        result[i, j] = num;

                    m++;
                }
                else n = "Right";
            }

            while (n != "Down")
            {
                if (i < row - 1 && result[i + 1, j] == 0)
                {
                    i++;
                    num++;

                    result[i, j] = num;

                    m++;
                }
                else n = "Down";
            }

            while (n != "Left")
            {
                if (j > 0 && result[i, j - 1] == 0)
                {
                    j--;
                    num++;

                    result[i, j] = num;

                    m++;
                }
                else n = "Left";
            }
            while (n != "Up")
            {
                if (i > 0 && result[i - 1, j] == 0)
                {
                    i--;
                    num++;

                    result[i, j] = num;

                    m++;
                }
                else n = "Up";
            }

        }
        return result;
    }

    ///<summary>
    ///Сортировка чисел в строках матрицы по убыванию
    ///<summary>
    public static int[,] SortMatrixRow(int[,] matrix)
    {
        int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            int[] matrixRow = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                matrixRow[i] = matrix[j, i];
            }
            Array.Sort(matrixRow);
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                result[j, i] = matrixRow[^(i + 1)];
            }

        }
        return result;
    }

    ///<summary>
    ///Нахождение строки с минимальной суммой чисел
    ///<summary>
    public static void MinSumRowInMatrix(int[,] matrix)
    {
        int result = 1, minRow = new int();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int sum = new int();
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[i, j];
            }
            minRow = minRow == 0 ? sum : minRow;
            if (sum < minRow)
            {
                minRow = sum;
                result = i + 1;
            }
        }
        WriteLine($"Минимальная сумма в {result} строке");
    }

    public static int[,] matrixMultiplication(int[,] firstMatrix, int[,] secondmatrix)
    {
        
    }
}




