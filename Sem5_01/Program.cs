// программа, которая выводит массив из 12 случайных элементов 
// от -9 до 9 и считает сумму отрицательных и положительных элементов в нем.

int[] RandArray (int length)
{
	int[] answer = new int[length];
	for(int i = 0; i < length; i++)
	{
		answer[i] = new Random().Next(-9, 10);
	}
	return answer;
}

void PrintArray(int[] arr)
{
	int count = arr.Length;
    Console.Write("[");
	for(int pos = 0; pos < count - 1; pos++)
	{
		Console.Write($"{arr[pos]}, ");
	}
    Console.Write($"{arr[arr.Length - 1]}]");
}

void SumMinMax(int[] arr)
{
    int min, max;
    min = max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
    if(arr[i] > 0) max += arr[i];
    else min += arr[i];
    }
    Console.WriteLine($"Max: {max}, min: {min}");
}

int[] array = RandArray(12);
PrintArray(array);
Console.WriteLine();
SumMinMax(array);