int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
        for(int i=0; i < size; i++)
            array[i] = new Random().Next(minValue, maxValue);
    
    return array;

}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
    Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// Задача 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int EvenNumber(int[]array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] >= 100 && array[i] < 1000)
            if(array[i] % 2 == 0)
                count += 1;
    return count;
}
Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size,min,max);
ShowArray(myArray);
int even = EvenNumber(myArray);
Console.WriteLine(even);
*/

// Задача 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int Sum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 1)
            sum  += array[i];
    }
    return sum;
}
Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size,min,max);
ShowArray(myArray);
int sum = Sum(myArray);
Console.WriteLine(sum);