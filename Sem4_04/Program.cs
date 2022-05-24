// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями 
// и единицами в случайном порядке.

void RandomArray(int n)
{
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(0, 2);
        Console.Write($"{arr[i]}, ");
    }
}

RandomArray(8);