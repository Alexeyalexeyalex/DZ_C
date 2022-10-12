// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using static System.Console;

Clear();
WriteLine("Введите числа:");
string[] inputArray = ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);

WriteLine(getSumEven(inputArray));




int getSumEven (string[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        result += Convert.ToInt32(array[i])>0? 1:0;
    }
    return result;
}
