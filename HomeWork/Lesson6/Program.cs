// Задача 1.  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

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