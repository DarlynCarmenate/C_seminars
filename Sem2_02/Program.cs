// Программа, которая выводит случайное число в диапазоне (10, 99) 
// и показывает самую большую цифру числа

int MaxNumber(int number)
{
    int n1 = number % 10;
    int n2 = number / 10;
    if (n1 > n2)
    {
        return n1;
    }
    else
    {
        return n2;
    }
}
int rnd = new Random().Next(10, 100);
Console.WriteLine(rnd);
Console.WriteLine(MaxNumber(rnd));