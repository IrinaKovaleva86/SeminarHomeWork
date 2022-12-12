// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Degree(int a, int b)
{
    int deg = a;
    for(int current = 1;current < b; current++)
    {
        deg = deg*a;
    }
    return deg;
}
Console.Write(("Input a number A: "));
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write(("Input a number B: "));
int numB = Convert.ToInt32(Console.ReadLine());
int deg = Degree(numA, numB);
Console.WriteLine ($"A в степени B равно {deg}");
*/

//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int Sum(int num)
{
    int result = 0;
    while(num != 0)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}
Console.Write(("Input a number: "));
int number = Convert.ToInt32(Console.ReadLine());
int sum = Sum(number);
Console.WriteLine ($"Сумма цифр равна {sum}");
*/
// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write("Input a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        array[i] = number;
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
}
int[] myArray = CreateArray(8);
ShowArray(myArray);
*/
