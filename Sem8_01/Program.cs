// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и 
// последнюю строку массива.

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

void ChangeRow(int[,] array)
{
	for (int j = 0; j < array.GetLength(1); j++)
	{
		(array[0, j], array[array.GetLength(0) - 1, j]) = 
		(array[array.GetLength(0) - 1, j], array[0, j]);
		}
}

int[,] array = FillArray(5,5, 10, 20);
PrintArray(array);
ChangeRow(array);
Console.WriteLine();
PrintArray(array);

