// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

Console.Clear();
int number = new Random().Next(100, 1000);
//Console.WriteLine(number);
int lastValue = number % 10; //получили последнюю цифру - остаток от деления на 10
//Console.WriteLine(firstValue);
int firstValue = number / 100; // целочисленное деление
//Console.WriteLine(secondValue);
// Console.WriteLine($" {number} -> {firstValue}{lastValue}");
Console.WriteLine($" {number} -> {firstValue * 10 + lastValue} ");