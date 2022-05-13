// Напишите программу, которая на вход принимает два числа 
// и проверяет, является ли первое квадратом второго.

Console.WriteLine("Введите первое число: ");
string s_a = Console.ReadLine();
int a = int.Parse(s_a);

Console.WriteLine("Введите второе число: ");
string s_b = Console.ReadLine();
int b = int.Parse(s_b);

if(a*a == b)
{
Console.WriteLine("Второе число является квадратом первого");
}
else
{
Console.WriteLine("Второе число не является квадратом первого");
}
