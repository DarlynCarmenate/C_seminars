// Задайте двумерный массив. Найдите элементы, у которых обе позиции чётные, 
// и замените эти элементы на их квадраты.

int[,] FillArray(int row, int column)
{
	int[,] array = new int[row, column];
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = new Random().Next(0, 10); 
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

int[,] FindOdd(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			if(i % 2 == 1 && j % 2 == 1)
            array[i, j] *= array[i, j]; 
		}
	} 
    return array;
}

int[,] array = FillArray(5, 5);
PrintArray(array);
Console.WriteLine();
FindOdd(array);
PrintArray(array);


