// Напишите программу, которая перевернёт одномерный массив

int[] RandArray(int length, int min, int max)
{
    int[] answer = new int[length];
    for (int i = 0; i < length; i++)
    {
        answer[i] = new Random().Next(min, max);
    }
    return answer;
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    Console.Write("[");
    for (int pos = 0; pos < count - 1; pos++)
    {
        Console.Write($"{arr[pos]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}]");
}

int[] RevMas(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size / 2; i++)
    {
        (arr[i], arr[size - i - 1]) = (arr[size - i - 1], arr[i]);
    }
    return arr;
}

int[] array = RandArray(9, 0, 20);
PrintArray(array);
Console.WriteLine();
RevMas(array);
PrintArray(array);