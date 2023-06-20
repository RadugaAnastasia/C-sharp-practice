// Напишите программу, которая принимает на вход 
// число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int GetCount(int n)
{
    int count = 0;
    while(n>0)
    {
        n /= 10;
        count++;
    }
    return count;
}

int number = Prompt("Введите число: ");
int result = GetCount(number);
Console.WriteLine($"{number} -> {result}");