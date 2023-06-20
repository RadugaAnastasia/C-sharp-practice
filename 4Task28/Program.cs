// Задача 28: Напишите программу, которая принимает на вход 
// число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num; 
}

int GetMult(int a)
{
    int sum = 1;
    for(int i = 1; i <= a; i++)
    {
        sum *= i;
    }
    return sum;
}

int number = Prompt("Введите число N: ");
int result = GetMult(number);
// Console.WriteLine("Произведение чисел от 1 до N = " + result);
Console.WriteLine($"{number} -> {result}");