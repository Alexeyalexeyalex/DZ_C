using static System.Console;

Clear();

Write("Введите число:");
int num = int.Parse(ReadLine()!);
int i = 1;
int num1 = num;
string num2 = string.Empty;


while (num >= i)
{
    num2 += num % 10;
    num = num / 10;
}

WriteLine(Convert.ToInt32(num2) == num1? "Да":"Нет");
