// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int number = Prompt("Введите число: ");
Console.WriteLine($"{number} -> {SumDigit(number)}");

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int SumDigit(int n)
{
    if (n == 0)
    {
        return 0; //этот 0 прибавляется к сумме, т.к. рекурсия завязана на сложении 
        //если бы рекурсия была завязана на умножении, то возвращать нужно было бы 1
    }
    return SumDigit(n / 10) + n % 10;
}