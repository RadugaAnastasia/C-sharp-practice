// Напишите программу, которая на вход принимает число и выдает его квадрат (число, умноженное само на себя)

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write ("Введите чило: ");
int number = int.Parse(Console.ReadLine()!);
int result = number * number;
Console.WriteLine("Квадрат числа = " + result);