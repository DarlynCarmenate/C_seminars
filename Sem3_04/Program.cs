// Задача 4. Программа, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23

void TwoMult(int number)
{
    if(number % 7 == 0 && number % 23 == 0)
    {
        Console.WriteLine("Yes");
    }
    else 
    {
        Console.WriteLine("No");
    }
}

TwoMult(161);