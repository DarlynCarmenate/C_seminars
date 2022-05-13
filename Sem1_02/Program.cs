// Напишите программу. которая на вход принимает число N, 
// а на выход отдает все числа от N до - N.

Console.WriteLine("Введите число: ");
string s_b = Console.ReadLine();
int b = int.Parse(s_b);

int a = - b;
while(a <= b)
{
	Console.Write($"{a} ");
a++;
}