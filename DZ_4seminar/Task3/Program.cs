// Напишите метод, который формирует массив из 8 случайных элементов и выводит их на экран.
using static System.Console;

Clear();
int lengt = 8;
PrintArray(CreateArray(lengt));




int[] CreateArray(int len)
{
    int[] result = new int[len];
    for (int i = 0; i < len; i++)
    {
        result[i] = new Random().Next();
    }
    return result;
}

void PrintArray(int[] Res)
{
    Write("[");
    for(int i =0; i<Res.Length-1;i++)
    {
        Write($"{Res[i]}, ");

    }
    Write($"{Res[Res.Length-1]}]");
}