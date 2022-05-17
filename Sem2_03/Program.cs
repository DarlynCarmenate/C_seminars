// Программа, которая принимает на вход два числа и выводит, является ли второе число кратно 
// первому. Если не является, то программа выводит остаток от деления.

void MultOrNot(int n1, int n2)
{
    if (n1 % n2 == 0)
    {
        Console.WriteLine($"{n1}, {n2} -> multiple");
    }
    else
    {
        Console.WriteLine($"{n1}, {n2} -> not multiple, the remainder -> {n1 % n2}");
    }
}

MultOrNot(30, 5);