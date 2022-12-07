// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int Findnum(int num)
{
    int des = num / 10;
    int ed = des % 10;
    return ed;
}

Console.Write("Input a threedigit number: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = Findnum(num);
Console.WriteLine(result);
*/

// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ThreeDigit(int num)
{
    int result = -1;
    if (num >= 100)
    {
        while(num >999)
        {
            num = num / 10;
        }
            result = num % 10;
    }
    else
        {
            Console.WriteLine("Третьей цифры нет");
        }
    return result;
}
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int number = ThreeDigit(num);
Console.WriteLine(number);
