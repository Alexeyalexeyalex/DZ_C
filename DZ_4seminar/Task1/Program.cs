//Напишите метод, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B с использованием цикла.
using static System.Console;

Clear();
Write("Введите первое число: ");
int num1 = int.Parse(ReadLine()!);
Write("Введите второе число: ");
int num2 = int.Parse(ReadLine()!);
WriteLine($"{num1} ^ {num2} = {Pow(num1,num2)}");



int Pow(int number1, int number2)
{
    int result = 1;
    for (int i=0; i<number2; i++)
    {
        result *= number1;
    }
    return result;
}





