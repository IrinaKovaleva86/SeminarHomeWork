// 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double[rows,columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = Math.Round(new Random().Next(minValue,maxValue) + new Random().NextDouble(), 1);
    return array;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "   ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
*/

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue,maxValue);
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j= 0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

// 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
void ShowElement(int[,] array, int i1, int j1)
{
    if(i1 < array.GetLength(0) && j1 < array.GetLength(1))
        Console.Write(array[i1,j1]);
    else
        Console.WriteLine("Числа c таким индексом в массиве нет");    
}

Console.Write("Input the index of element by row: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the index of element by column: ");
int j = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
ShowElement(myArray, i, j);
*/

//3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
void FindAverage(int[,] array)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double avg = 0;
        double sum = 0;
        for(int i = 0; i < array.GetLength(0); i++)
            sum += array[i,j]; 
        avg = Math.Round(sum / array.GetLength(0),2);
        Console.Write(avg + "  ");
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
FindAverage(myArray);
*/

