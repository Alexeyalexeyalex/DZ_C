//Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
using static System.Console;

Clear();
Write("Введите число: ");
int num1 = int.Parse(ReadLine()!);
WriteLine($"Сумма цифр числа {num1} = {Sum(num1)}");

int Sum(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number%10;
        number = number/10;
    }
    return result;
}