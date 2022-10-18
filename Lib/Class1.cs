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
    ///Создание двумерной матрицы со случайными числами
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

    ///<summary>
    ///Перемножение матриц
    ///<summary>
    public static int[,] matrixMultiplication(int[,] firstMatrix, int[,] secondmatrix)
    {
        int[,] result = new int[firstMatrix.GetLength(0), secondmatrix.GetLength(1)];
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                for (int n = 0; n < firstMatrix.GetLength(1); n++)
                {
                    result[i, j] += firstMatrix[i, n] * secondmatrix[n, j];
                }
            }
        }

        return result;
    }
    ///<summary>
    ///Создание трехмерной матрицы со случайными числами
    ///<summary>
    public static int[,,] CreateMatrix(int row, int column, int depth, int minValue, int maxValue)
    {
        Random rnd = new Random();
        int[] randomNumberArray = new int[maxValue];
        int[,,] result = new int[row, column, depth];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                for (int k = 0; k < depth; k++)
                {
                    int randomNumber = rnd.Next(minValue, maxValue + 1);
                    for (int n = 0; n < randomNumberArray.Length; n++)
                    {
                        if (randomNumber == randomNumberArray[n])
                        {
                            n = 0;
                            randomNumber = rnd.Next(minValue, maxValue + 1);
                        }
                        else result[i, j, k] = randomNumber;
                    }

                }
            }
        }
        return result;
    }

    ///<summary>
    ///Печать трехмерной матрицы int
    ///<summary>
    public static void PrintThreeMatrix(int[,,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(2); k++)
                {
                    Write($"{matrix[i, j, k]} ");
                }
            }
            WriteLine();
        }
    }
    public static string FactorialN(int n)
    {
        if (n == 1) return n.ToString();
        return n + ", " + FactorialN(n - 1);

    }

    public static int SumBetweenMN(int m, int n)
    {
        if (m == n) return n;
        return SumBetweenMN(m + 1, n) + m;
    }

    public static int AkermanMN(int m, int n)
    {
        if (m == 0) return n + 1;
        if (n == 0) return AkermanMN(m - 1, 1);
        return AkermanMN(m - 1, AkermanMN(m, n - 1));
    }
}




