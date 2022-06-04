// Задайте двумерный массив. Найдите сумму элементов главной диагонали.

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

int Diagonal(int[,] array)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
	{
		result += array[i, i];
	
	} 
    return result;
}

int[,] array = FillArray(3, 3);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(Diagonal(array));




