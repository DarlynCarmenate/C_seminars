// Вычислить а в степени n, рекурсия - упрощенная версия

// Обычный вариант решения
// int PowerFor(int a, int n)
// {
//     int result = 1;
//     for (int i = a; i <= n; i++)
//     {
//         result *= a;
//     }
//     return result;
// }

int PowerRecMath(int a, int n)
{
if (n == 0) return 1;
else if (n % 2 == 0) return PowerRecMath(a * a, n /2);
else return PowerRecMath(a, n -1) * a;
}

Console.WriteLine(PowerRecMath(2, 10));
