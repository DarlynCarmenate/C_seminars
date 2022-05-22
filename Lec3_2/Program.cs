// Сортировка массива методом выбора

int[] arr = {1, 4, 2, 8, 12, 5, 0, 3, 5, 1};

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SortArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minIndex = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minIndex]) minIndex = j;
        }

        int temp = array[i];
        array[i] = array[minIndex];
        array[minIndex] = temp;
    }
}

PrintArray(arr);
SortArray(arr);
PrintArray(arr);