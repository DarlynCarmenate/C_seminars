// Напишите программу, которая принимает на вход три числа и проверяет,
//  может ли существовать треугольник с сторонами такой длины.

string TriangleCheck(int a, int b, int c)
{
    if(a + b > c && b + c > a && c + a > b) return "Yes";
    return "No";
}

Console.WriteLine(TriangleCheck(4, 6, 7));
