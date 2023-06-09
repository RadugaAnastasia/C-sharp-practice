// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

Console.WriteLine("Введите трехзначное число: ");
int.TryParse(Console.ReadLine(), out int result);
int r = result % 10;

Console.WriteLine($" {result} ->  {r} ");