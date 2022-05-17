// Напишите программу, которая на вход принимает трехзначное число, а на выходе
// показывает его последнюю цифру

int LastNumber(int number)
{
    return number % 10;
}
Console.WriteLine(LastNumber(395));

