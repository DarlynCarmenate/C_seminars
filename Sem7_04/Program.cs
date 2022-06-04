// Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, 
// выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.

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

int[,] FindNum(int[,] array, int num)
{
    for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			if(array[i, j] == num) Console.WriteLine($"{i + 1}, {j + 1}");
		}
	} 
    return array;
}

int[,] array = FillArray(5, 5);
PrintArray(array);
Console.WriteLine();
FindNum(array, 4);



