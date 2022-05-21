// Напишите программу, которая принимает число N и выдает таблицу квадратов от 1 до N

void Squares(int num)
{
    double[] arr = new double[num];
    int i = 0;
    while (i < num)
    {
    arr[i] = Math.Pow((i+1), 2);
    Console.Write($"{arr[i]}, ");    
    i++;
    }
}

Squares(5);