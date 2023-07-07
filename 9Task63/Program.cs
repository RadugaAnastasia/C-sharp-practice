// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Все числа в промежутке от 1 до {N}: {Range(N)}");


string Range(int N)
{
    if(N == 1)
    {
        return "1";
    }
    // return Range(N-1) + ", " + N.ToString(); выводится с 1 до N
    return N + ", " + Range(N-1); //Вывод c N до 1
}