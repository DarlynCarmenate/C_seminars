// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

string DecimToDouble(int num)
{
    string result = "";
    while(num > 0)
    {
        result = num%2 + result;
        num = num / 2;
    }
    return result;
}

Console.WriteLine(DecimToDouble(45));