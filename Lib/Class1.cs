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

    public static int[,] CreateSpiralMatrix(int row, int column)
    {
        int[,] result = new int[row, column];
        int num = 1, n = 0, i = 0, j = 0, m = 1;
        result[0, 0] = num;
        while (m != row * column)
        {
            while (n != 3)
            {
                if (j < column - 1 && result[i, j + 1] == 0)
                {
                    j++;
                    num++;
                    if (result[i, j] == 0)
                    {
                        result[i, j] = num;
                    }
                    m++;
                }
                else n = 3;
            }

            while (n != 4)
            {
                if (i < row - 1 && result[i + 1, j] == 0)
                {
                    i++;
                    num++;
                    if (result[i, j] == 0)
                    {
                        result[i, j] = num;
                    }
                    m++;
                }
                else n = 4;
            }

            while (n != 5)
            {
                if (j > 0 && result[i, j - 1] == 0)
                {
                    j--;
                    num++;
                    if (result[i, j] == 0)
                    {
                        result[i, j] = num;
                    }
                    m++;
                }
                else n = 5;
            }
            while (n != 6)
            {
                if (i > 0 && result[i - 1, j] == 0)
                {
                    i--;
                    num++;
                    if (result[i, j] == 0)
                    {
                        result[i, j] = num;
                    }
                    m++;
                }
                else n = 6;
            }

        }










        // int num = 1, i = 0, j = 1, a = column - 2, b = row - 2, columnI = 0,d = 0;


        // for (int n = 0; n < 2; n++)
        // {
        //     for (; i < column; i++)
        //     {
        //         result[columnI, i] = num;
        //         num++;
        //     }
        //     for (; j < row; j++)
        //     {
        //         result[j, column - 1] = num;
        //         num++;
        //     }
        //     for (; a >= columnI; a--)
        //     {
        //         result[column - 1, a] = num;
        //         num++;
        //     }
        //     for (; b != columnI; b--)
        //     {
        //         result[b, columnI] = num;
        //         num++;
        //     }
        //     column -= 1;
        //     row -= 1;
        //     d++;
        //     i=d;
        //     j=d;
        //     a=d;
        //     b=d;
        //     columnI ++;


        // for (int i = 1; i < column-1; i++)
        // {
        //     result[1, i] = num;
        //     num++;
        // }

        // }



        return result;
    }
}




