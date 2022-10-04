//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using static System.Console;

Clear();
Write("Введите размер массива: ");
int SizeArray = int.Parse(ReadLine()!);
int[] ResultArray = CreateArray(SizeArray);
Write($"[{String.Join(',',ResultArray)}] = ");
Write(CheckEven(ResultArray));


int[] CreateArray(int size)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = rnd.Next(100, 999 + 1);
    }
    return result;
}

int CheckEven(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        result += array[i] % 2 == 0 ? 1 : 0;
    }
    return result;
}

