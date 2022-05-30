// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

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

void ChangeArray(int[] arr, int num)
{
    string flag = "No";
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == num) flag = "Yes";
        break;
    }
    Console.WriteLine(flag);
}

int[] array = RandArray(10, 0, 10);
PrintArray(array);
Console.WriteLine();
ChangeArray(array, 4);
