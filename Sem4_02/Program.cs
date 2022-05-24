// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int CountDigits(int number)
{
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count ++;
    }
    return count;
}

Console.WriteLine(CountDigits(3456777));