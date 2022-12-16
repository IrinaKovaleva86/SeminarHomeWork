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
