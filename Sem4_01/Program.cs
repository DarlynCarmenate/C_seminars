// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int AllSum(int number)
{
    int sum = 0;
    for (int i = 0; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}

Console.WriteLine(AllSum(7));