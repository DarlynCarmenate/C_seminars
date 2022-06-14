// В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
// Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.
// n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са, 
// ав, ва, ви, ив, св, вс

char[] massiv = {'а', 'и', 'с', 'в'};
int count = 2;

void FindWords (char[] search, char[] dict, int n = 0)
{
    if(n == dict.Length) 
    {
    Console.WriteLine(new string(dict));
    return;
    }
    for(int i = 0; i < search.Length; i++)
    {
        dict[n] = search[i];
        FindWords(search, dict, n + 1);
    }
}

FindWords(massiv,new char[count]);