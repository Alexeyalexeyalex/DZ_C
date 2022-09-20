//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
using static System.Console;

Clear();

Write("Введите число: ");
int num = int.Parse(ReadLine()!);
int num2 = (num/10)%10;

Write($"{num2}");
