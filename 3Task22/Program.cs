// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
void FindSQ(int n)
{
    int i = 1;
    while(i <= n)
{
    Console.Write(i*i + "  ");
    i ++;
}
}

int N = Prompt("Введите число N: ");
FindSQ(N);
