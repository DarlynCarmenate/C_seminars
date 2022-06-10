// Напишите программу, которая на вход принимает два числа A и B, и возводит число А 
// в целую степень B с помощью рекурсии.

int ExponentNum(int a, int b)
{
    if(b == 0) return 1;
    return ExponentNum(a, (b - 1)) * a;
}

Console.Write(ExponentNum(2, 5));