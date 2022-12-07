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

//Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool Days(int num)
{
    if(num > 0 && num < 8)
    {
        if(num == 6 || num == 7)
        {
            Console.Write("Выходной");
        }
        else
        {
            Console.Write("Рабочий день");
        }
    }
    else
    {    
        Console.Write("Не верное число");
    }
    return true;
}

Console.Write("Input a number from 1 to 7: ");
int num = Convert.ToInt32(Console.ReadLine());
Days(num);
*/