//Задача 1. Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом.

/*
bool Palindrom(int number)
{
    int n = number;
    int temp = 0;
    int revNum = 0;
    while(n > 0)
        {
            temp = n % 10;
            revNum = revNum*10 + temp;
            n /= 10;
        }

    n = number;
    if (n == revNum)
        {
            Console.WriteLine("Yes");
            return true;
        }
    else
        {
            Console.WriteLine("No");
            return false;
        }
}
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Palindrom(num);
*/
