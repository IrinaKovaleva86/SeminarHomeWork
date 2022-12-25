// 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
/*
void ShowNumbers(int n)
{
    Console.Write(n +" ");
    if(n>1) ShowNumbers(n-1);
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowNumbers(num);
*/

// 2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumOfNumbers(int m, int n)
{
    if(n > m) return SumOfNumbers(m, n-1) + n;
    if(n < m) return SumOfNumbers(n,m);
    else return m;
}

Console.Write("Input the first number: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: ");
int numN = Convert.ToInt32(Console.ReadLine());
SumOfNumbers(numM,numN);
Console.Write(SumOfNumbers(numM,numN));
*/

// 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int Ackerman(int m,int n)
{
    if(m == 0) return n+1;
    if (m > 0 && n == 0) return Ackerman(m-1,1);
    if(m > 0 && n > 0) return Ackerman (m-1, Ackerman(m,n-1));
    return Ackerman(m ,n);
}
Console.Write("Input the first number: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: ");
int numN = Convert.ToInt32(Console.ReadLine());
int ack = Ackerman(numM,numN);
Console.Write($"A({numM},{numN}) = {ack}");
*/

