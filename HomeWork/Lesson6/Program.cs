// Задача 1.  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int PositiveNumber(int num)
{
    int count = 0;
    for(int i = 0; i < num; i++)
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if(number > 0)
            count++;
    }
    return count;
}

Console.Write("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int positive = PositiveNumber(m);
Console.WriteLine("Положительных чисел: " + positive);
*/

// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
void Point(double k1, double b1, double k2, double b2)
{
    double x = (b2-b1)/(k1-k2);
    double y = k1*((b2-b1)/(k1-k2)) + b1;
    if((k1 == k2) && (b1 == b2))
        Console.WriteLine("Прямые совпадают");
    if((k1 == k2) && (b1 != b2))
        Console.WriteLine("Прямые параллельны");
    else
        Console.WriteLine($"Точка пересечения прямых  ({x}, {y})");  
}
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Point(k1,b1,k2,b2);
*/
