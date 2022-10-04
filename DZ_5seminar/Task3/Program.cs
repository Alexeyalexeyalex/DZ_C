// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

using static System.Console;

Clear();
Write("Введите размер массива: ");
int SizeArray = int.Parse(ReadLine()!);
Diff(CreateArray(SizeArray));


int[] CreateArray(int size)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = rnd.Next(1, 99 + 1);
    }
    return result;
}

void Diff(int[] Array)
{
    int result = 0;
    int min = Array[1];
    int max = Array[1];
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i]>max) max=Array[i];
        if (Array[i]<min) min=Array[i];
    }
    result = max-min;
    Write($"[{String.Join(',',Array)}] = {result}");
}