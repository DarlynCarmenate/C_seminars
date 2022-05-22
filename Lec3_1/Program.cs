string Method(int count, string text)
{
    int i = 0;
    string result = string.Empty;

    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method(10, "t");
Console.WriteLine(res);
