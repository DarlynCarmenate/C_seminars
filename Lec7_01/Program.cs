// Сoберите строку с числами от a до b, a <=b

string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

Console.Write(NumbersFor(1, 10));

