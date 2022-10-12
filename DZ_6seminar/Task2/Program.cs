// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using static System.Console;

Clear();

WriteLine("Введите данные b1, k1, b2 и k2:");
string[] inputArray = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
getXY(inputArray);




void getXY(string[] array)
{
    double b1 = Convert.ToDouble(array[0]);
    double k1 = Convert.ToDouble(array[1]);
    double b2 = Convert.ToDouble(array[2]);
    double k2 = Convert.ToDouble(array[3]);
    
    double x = -(b1-b2)/(k1-k2); 
    double y = k2*x+b2;
    
    WriteLine($"({x}; {y})");

}