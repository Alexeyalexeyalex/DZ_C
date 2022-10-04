// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using static System.Console;

Clear();
Write("Введите размер массива: ");
int SizeArray = int.Parse(ReadLine()!);
EvenPosition(CreateArray(SizeArray));



int[] CreateArray(int size)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = rnd.Next(1, 9 + 1);
    }
    return result;
}

void EvenPosition(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        result+=array[i];
    }
    Write($"[{String.Join(',',array)}] = {result}");
}