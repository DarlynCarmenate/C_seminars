// Сoберите строку с числами от a до b, a <=b

string NumberRec(int a, int b)
{
    if(a <= b) return $"{a} {NumberRec(a + 1, b)}";
    else return string.Empty;
}

Console.WriteLine(NumberRec(1, 10));