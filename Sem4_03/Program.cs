// Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.

int PowDigits(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        result *= i;
    }
    return result;
}

Console.WriteLine(PowDigits(2));
