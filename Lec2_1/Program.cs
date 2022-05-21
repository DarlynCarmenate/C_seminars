// Лекция 2. Массивы: Найти положение элемента в массиве
void FillArray(int[] collection)
{
    int count = collection.Length;
    int index = 0;

    while (index < count)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int length = col.Length;
    int position = 0;

    while (position < length)
    {
        Console.Write($"{col[position]}, ");
        position++;
    }
}

int IndexOf(int[] col, int find)
{
    int count = col.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (col[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 3); // здесь вводим элемент
Console.WriteLine(pos);

