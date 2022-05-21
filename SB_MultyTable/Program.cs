// Таблица умножения

MultiplyTable(6);
void MultiplyTable(int n)
{
    int[,] z = MultCalc(n);
    Header(n);
    MultPrint(z, n);

    int[,] MultCalc(int n)
    {
        int[,] z = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                z[i, j] = (i + 1) * (j + 1);
            }
        }
        return z;
    }

    void Header(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write($"\t{i + 1}");
        }

        Console.WriteLine();
        Console.WriteLine();
    }

    void MultPrint(int[,] z, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{i + 1}");
            for (int j = 0; j < n; j++)
            {
                Console.Write($"\t{z[j, i]}");
            }
            Console.WriteLine();
        }
    }
}
