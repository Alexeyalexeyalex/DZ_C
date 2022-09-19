using static System.Console;

Clear();

Write("Введите число: ");
int N = int.Parse(ReadLine()!);
int i = 0;

if (N > 0)
{
    while (i < N)
    {
        i++;
        if (i % 2 == 0) Write($"{i} ");
    }
}
else
{
    while (i > N)
    {
        i--;
        if (i % 2 == 0) Write($"{i} ");
    }

}



