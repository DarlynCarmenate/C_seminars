// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. 


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

int TheNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 9 && arr[i] < 100) count++;
    }
    return count;
}

int[] array = RandArray(10, 0, 200);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(TheNumber(array));
