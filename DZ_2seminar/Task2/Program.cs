// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
using static System.Console;

Clear();

Write("Введите число: ");
int num = int.Parse(ReadLine()!);
int num3 = (num / 100)%10;
Write(num / 100 > 0? num3:"третьей цифры нет");
