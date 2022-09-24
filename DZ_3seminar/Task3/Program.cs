using static System.Console;

Clear();

Write("Введите число:");
int num = int.Parse(ReadLine()!);
int i =1;
string result = "1";

while (i<num)
{
    i++;
    result+=$", {Math.Pow(i,3)}";
}

WriteLine(result);