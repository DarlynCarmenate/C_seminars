// Дано натуральное число N. Выведите все егоцифры в обратном порядке по одному.

void NumsVersa(int n)
{
    if(n == 0) return;
    Console.Write(n % 10);
    NumsVersa(n/10);
}

NumsVersa(123);
