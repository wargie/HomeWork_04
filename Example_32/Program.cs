//32.Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int arrayLength = 8, min = 0, max = 1;

int[] CreateArray(int arrayLength, int min, int max)
{
    int[] arr = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    foreach (int v in array)
    {
        Console.Write($"{v} ");
    }
}

PrintArray(CreateArray(arrayLength, min, max));