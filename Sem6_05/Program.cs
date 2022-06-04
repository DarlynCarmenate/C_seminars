// Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.

int[] RandArray (int length, int min, int max)
{
	int[] answer = new int[length];
	for(int i = 0; i < length; i++)
	{
		answer[i] = new Random().Next(min, max);
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

int[] CopyArray(int[] arr)
{
    int size = arr.Length;
    int[] new_arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        new_arr[i] = arr[i];
    }
    return new_arr;
}

int[] array = RandArray(10, 0, 10);
PrintArray(array);
Console.WriteLine();
CopyArray(array);
PrintArray(array);
