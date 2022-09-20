//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
using static System.Console;

Clear();

Write("Введите число: ");
int num = int.Parse(ReadLine()!);
string day = "Нет";

if (num>7||num<1) day = "Это не день недели!";
if (num==6||num==7) day = "Да";

Write(day);


