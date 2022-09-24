using static System.Console;
using static System.Math;

Clear();

Write("Введите x 1 точки:");
int x1 = int.Parse(ReadLine()!);

Write("Введите y 1 точки:");
int y1 = int.Parse(ReadLine()!);

Write("Введите z 1 точки:");
int z1 = int.Parse(ReadLine()!);

Write("Введите x 2 точки:");
int x2 = int.Parse(ReadLine()!);

Write("Введите y 2 точки:");
int y2 = int.Parse(ReadLine()!);

Write("Введите z 2 точки:");
int z2 = int.Parse(ReadLine()!);

WriteLine($"{Sqrt(Pow(x1 - x2, 2) + Pow(y1 - y2, 2) + Pow(z1 - z2, 2)):f2}");