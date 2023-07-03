// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int N = TakeUserNum();
Console.Write($" Если N = {N} -> ");
PrintArray(Fibonacci(N));

int TakeUserNum()
{
    int UserNum;
    while(!int.TryParse(Console.ReadLine(), out UserNum))
    Console.WriteLine("Пожалуйста, введите число: ");

    return UserNum;
}

int[] Fibonacci(int N)
{
    int[] fibonacci = new int[N];
    fibonacci[0] = 0;
    fibonacci[1] = 1;
    for (int i = 2; i < N; i++)
    {
        fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
    }
    return fibonacci;
}

void PrintArray(int[] array)
{
    foreach (var element in array)
    {
        Console.Write($"{element} ");
    }
}