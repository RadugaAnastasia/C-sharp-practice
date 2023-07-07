// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("Введите число M (меньшее): ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N (больнее): ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Все числа в промежутке от {M} до {N}: {Range(N,M)}");

string Range(int n, int m)
{
    if(n == m)
    {
        return m.ToString();
    }
    return Range(n-1, m) + ", " + n;
}