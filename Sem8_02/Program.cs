// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] FillArray(int row, int column, int from, int to)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(from, to);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void TranspArr(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    if (row != column)
    {
        Console.WriteLine("It's impossible");
    }
    else
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < i; j++)
            {
                (array[i, j], array[j, i]) = (array[j, i], array[i, j]);
            }
        }
    }
}

int[,] array = FillArray(5, 5, 10, 20);
PrintArray(array);
Console.WriteLine();
TranspArr(array);
PrintArray(array);