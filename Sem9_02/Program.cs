// Задайте значения M и N. Напишите программу, которая рекурсивно 
// выведет все натуральные числа в промежутке от M до N.

void ValueSet(int m, int n)
{
    if(n < m ) return;
    ValueSet(m, n - 1);
    Console.Write($"{n} ");
}

ValueSet(1, 10);
